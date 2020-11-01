using PizzeriaNET.Client.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzeriaNET.Client.Web.Services
{
    public interface IViewModelService
    {
        public Task<IEnumerable<OrderHistoryWebModel>> GetOrderHistory(string email);
        public Task<IEnumerable<MenuItemWebModel>> GetMenuItems();
        public Task PlaceOrder(OrderWebModel order);
    }
}