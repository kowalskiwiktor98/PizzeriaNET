using System.Collections.Generic;
using System.Threading.Tasks;
using PizzeriaNET.API.Models;

namespace PizzeriaNET.API.Database
{
    public interface IDatabaseHelper
    {
        public Task<IEnumerable<MenuItems>> GetMenuItems();
        public Task InsertOrder(PlaceOrderRequest placeOrderRequest);
    }
}