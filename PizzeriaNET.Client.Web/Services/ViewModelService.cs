﻿using PizzeriaNET.Client.Core.Models;
using PizzeriaNET.Client.Core.Services;
using PizzeriaNET.Client.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzeriaNET.Client.Web.Services
{
    public class ViewModelService : IViewModelService
    {
        private readonly ICommunicationService _communicationService;

        public ViewModelService(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        public async Task<IEnumerable<OrderHistoryWebModel>> GetOrderHistory(string email)
        {
            var orderHistory = await _communicationService.GetOrderHistory(email);
            var orderHistoryViewModel = new List<OrderHistoryWebModel>();

            foreach (var order in orderHistory)
            {
                var orderItems = new List<OrderHistoryItemWebModel>();

                foreach (var item in order.OrderItems)
                {
                    orderItems.Add(new OrderHistoryItemWebModel()
                    {
                        Name = item.Name,
                        Quantity = item.Quantity,
                        Price = item.Price
                    });
                }

                orderHistoryViewModel.Add(new OrderHistoryWebModel()
                {
                    ID = order.ID,
                    Date = order.Date,
                    Comment = order.Comment,
                    OrderItems = orderItems
                });
            }

            return orderHistoryViewModel;

        }

        public async Task<IEnumerable<MenuItemWebModel>> GetMenuItems()
        {
            var webMenuItems = new List<MenuItemWebModel>();
            var menuItems = await _communicationService.GetMenuItems();

            foreach (var item in menuItems)
            {
                webMenuItems.Add(new MenuItemWebModel()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Category = item.Category,
                    Price = item.Price
                });
            }

            return webMenuItems;
        }

        public async Task PlaceOrder(OrderWebModel orderWebModel)
        {
            var orderedItems = new List<Core.Models.OrderItemModel>();

            foreach (var item in orderWebModel.OrderedItems)
            {
                orderedItems.Add(new Core.Models.OrderItemModel()
                {
                    ItemID = item.ItemID,
                    Quantity = item.Quantity
                });
            }

            var order = new OrderModel()
            {
                SendEmailNotification = orderWebModel.SendEmailNotification,
                Email = orderWebModel.Email,
                Comment = orderWebModel.Comment,
                OrderTime = orderWebModel.OrderTime,
                OrderedItems = orderedItems
            };

            await _communicationService.PlaceOrder(order);
        }
    }
}
