using PizzeriaNET.Client.WinForms.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzeriaNET.Client.WinForms.Services
{
    public interface IViewModelService
    {
        public Task<IEnumerable<MenuItemFormModel>> GetMenuItems();
        public Task<IEnumerable<OrderHistoryFormModel>> GetOrderHistory(string email);
        public Task PlaceOrder(OrderFormModel order);
    }
}