using System.Collections.Generic;
using System.Threading.Tasks;
using PizzeriaNET.Client.Core.Models;

namespace PizzeriaNET.Client.Core.Services
{
    public interface ICommunicationService
    {
        public Task<IEnumerable<MenuItemModel>> GetMenuItems();
        public Task<IEnumerable<OrderHistoryModel>> GetOrderHistory(string email);
        public Task PlaceOrder(OrderModel order);
    }
}