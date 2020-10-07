using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PizzeriaNET.Client.Core.Models;
using RestSharp;

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
    }
}
