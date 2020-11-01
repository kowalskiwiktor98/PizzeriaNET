using PizzeriaNET.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzeriaNET.API.Database
{
    public interface IDatabaseHelper
    {
        public Task<IEnumerable<MenuItems>> GetMenuItems();
        public Task<IEnumerable<OrderHistoryDB>> InsertOrder(PlaceOrderRequest placeOrderRequest);
        public Task<IEnumerable<OrderHistoryDB>> SelectOrderHistory(string email);
    }
}