using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PizzeriaNET.API.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PizzeriaNET.API.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _logger;
        private readonly IOptions<NotificationConfig> _options;
        private readonly string _sendgridAPI;

        public NotificationService(ILogger<NotificationService> logger, IOptions<NotificationConfig> options)
        {
            _logger = logger;
            _options = options;
            _sendgridAPI = Environment.GetEnvironmentVariable("sendgridAPI");
        }

        public async Task SendConfirmEmail(OrderHistory order, string email)
        {
            _logger.LogInformation("Sending email notification");
            var client = new SendGridClient(_sendgridAPI);
            var from = new EmailAddress(_options.Value.EmailSenderAddress, _options.Value.EmailSenderTitle);
            var subject = "Order Confirmation";
            var to = new EmailAddress(email);
            var content = new List<string>();
            content.Add("Confirming your order");
            content.Add($"at: {order.Date}");
            content.Add($"comment: {order.Comment}");
            foreach (var item in order.OrderItems)
            {
                content.Add($"{item.Name} - {item.Quantity} * {item.Price}PLN");
            }
            var msg = MailHelper.CreateSingleEmail(from, to, subject, string.Join('\n', content), string.Empty);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
            _logger.LogInformation($"SendGrid response: {response.StatusCode}");
        }
    }
}
