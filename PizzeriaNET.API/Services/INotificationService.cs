using System.Threading.Tasks;

namespace PizzeriaNET.API.Services
{
    public interface INotificationService
    {
        public Task SendConfirmEmail(string receiverEmail);
    }
}