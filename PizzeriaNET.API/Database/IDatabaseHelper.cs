using System.Collections.Generic;
using System.Threading.Tasks;
using PizzeriaNET.API.Models;

namespace PizzeriaNET.API.Database
{
    public interface IDatabaseHelper
    {
        public Task<IEnumerable<OrderHistoryEntry>> SelectOrderHistory(string email);
        public Task InsertOrder(PlaceOrderRequest placeOrderRequest);
        public Task<IEnumerable<MenuItems>> GetMenuItems();
    }
}