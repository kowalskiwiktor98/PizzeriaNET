using Microsoft.Extensions.Logging;
using PizzeriaNET.Client.Core.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzeriaNET.Client.Core.Services
{
    public class CommunicationService : ICommunicationService
    {
        private readonly ILogger<CommunicationService> _logger;
        private readonly string _remoteAddress;

        public CommunicationService(ILogger<CommunicationService> logger, string remoteAddress)
        {
            _logger = logger;
            _remoteAddress = remoteAddress;
        }

        public async Task<IEnumerable<MenuItemModel>> GetMenuItems()
        {
            _logger.LogInformation("Begin GetMenuItems");
            IEnumerable<MenuItemModel> menuItems = new List<MenuItemModel>();
            var client = new RestClient(_remoteAddress);
            var request = new RestRequest("api/menu", Method.GET);
            try
            {
                var response = await client.ExecuteAsync<IEnumerable<MenuItemModel>>(request);
                menuItems = response.Data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return menuItems;
        }

        public async Task<IEnumerable<OrderHistoryModel>> GetOrderHistory(string email)
        {
            _logger.LogInformation("Begin GetOrderHistory");
            IEnumerable<OrderHistoryModel> orderHistory = new List<OrderHistoryModel>();

            var client = new RestClient(_remoteAddress);
            var request = new RestRequest("api/orders/getorderhistory", Method.GET);
            request.AddQueryParameter("email", email);
            try
            {
                var response = await client.ExecuteAsync<IEnumerable<OrderHistoryModel>>(request);
                orderHistory = response.Data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return orderHistory;
        }

        public async Task PlaceOrder(OrderModel order)
        {
            _logger.LogInformation("Begin PlaceOrder");
            var client = new RestClient(_remoteAddress);
            var request = new RestRequest("api/orders/placeorder", Method.POST);
            request.AddJsonBody(order);
            try
            {
                await client.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}
