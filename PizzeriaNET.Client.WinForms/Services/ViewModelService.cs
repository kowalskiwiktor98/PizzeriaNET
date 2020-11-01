using PizzeriaNET.Client.Core.Models;
using PizzeriaNET.Client.Core.Services;
using PizzeriaNET.Client.WinForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderItemModel = PizzeriaNET.Client.Core.Models.OrderItemModel;

namespace PizzeriaNET.Client.WinForms.Services
{
    public class ViewModelService : IViewModelService
    {
        private readonly ICommunicationService _communicationService;

        public ViewModelService(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        public async Task<IEnumerable<MenuItemFormModel>> GetMenuItems()
        {
            var dataGridMenuItems = new List<MenuItemFormModel>();
            var menuItems = await _communicationService.GetMenuItems();

            if (menuItems is null) return null;

            foreach (var item in menuItems)
            {
                dataGridMenuItems.Add(new MenuItemFormModel()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Category = item.Category,
                    Price = item.Price
                });
            }

            return dataGridMenuItems;
        }

        public async Task<IEnumerable<OrderHistoryFormModel>> GetOrderHistory(string email)
        {
            var orderHistory = await _communicationService.GetOrderHistory(email);
            var orderHistoryViewModel = new List<OrderHistoryFormModel>();

            if (orderHistory is null) return null;

            foreach (var order in orderHistory)
            {
                var orderItems = new List<OrderHistoryItemFormModel>();

                foreach (var item in order.OrderItems)
                {
                    orderItems.Add(new OrderHistoryItemFormModel()
                    {
                        Name = item.Name,
                        Quantity = item.Quantity,
                        Price = item.Price
                    });
                }

                orderHistoryViewModel.Add(new OrderHistoryFormModel()
                {
                    ID = order.ID,
                    Date = order.Date,
                    Comment = order.Comment,
                    OrderItems = orderItems
                });
            }

            return orderHistoryViewModel;
        }

        public async Task PlaceOrder(OrderFormModel orderFormModel)
        {
            var orderedItems = new List<OrderItemModel>();

            foreach (var item in orderFormModel.OrderedItems)
            {
                orderedItems.Add(new OrderItemModel()
                {
                    ItemID = item.ItemID,
                    Quantity = item.Quantity
                });
            }

            var order = new OrderModel()
            {
                SendEmailNotification = orderFormModel.SendNotification,
                Email = orderFormModel.Email,
                Comment = orderFormModel.Comment,
                OrderTime = orderFormModel.OrderTime,
                OrderedItems = orderedItems
            };

            await _communicationService.PlaceOrder(order);
        }
    }
}
