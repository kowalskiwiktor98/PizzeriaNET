using System.Collections.Generic;
using System.Threading.Tasks;
using PizzeriaNET.Client.WinForms.Models;

namespace PizzeriaNET.Client.WinForms.Services
{
    public interface IViewModelService
    {
        public Task<IEnumerable<MenuItemFormModel>> GetMenuItems();
        public Task<IEnumerable<OrderHistoryFormModel>> GetOrderHistory(string email);
        public Task PlaceOrder(OrderFormModel order);
    }
}