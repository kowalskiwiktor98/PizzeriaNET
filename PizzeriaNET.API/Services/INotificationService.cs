using System.Threading.Tasks;
using PizzeriaNET.API.Models;

namespace PizzeriaNET.API.Services
{
    public interface INotificationService
    {
        public Task SendConfirmEmail(OrderHistory order, string email);
    }
}