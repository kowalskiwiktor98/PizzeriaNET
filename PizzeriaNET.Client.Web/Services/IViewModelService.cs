using System.Collections.Generic;
using System.Threading.Tasks;
using PizzeriaNET.Client.Web.Models;

namespace PizzeriaNET.Client.Web.Services
{
    public interface IViewModelService
    {
        public Task<IEnumerable<OrderHistoryWebModel>> GetOrderHistory(string email);
        public Task<IEnumerable<MenuItemWebModel>> GetMenuItems();
    }
}