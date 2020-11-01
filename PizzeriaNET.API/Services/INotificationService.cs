using PizzeriaNET.API.Models;
using System.Threading.Tasks;

namespace PizzeriaNET.API.Services
{
    public interface INotificationService
    {
        public Task SendConfirmEmail(OrderHistory order, string email);
    }
}