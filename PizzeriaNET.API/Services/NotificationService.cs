using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PizzeriaNET.API.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _logger;
        private readonly string _sendgridAPI;

        public NotificationService(ILogger<NotificationService> logger)
        {
            _logger = logger;
            _sendgridAPI = Environment.GetEnvironmentVariable("sendgridAPI");
        }

        public async Task SendConfirmEmail(string receiverEmail)
        {
            var client = new SendGridClient(_sendgridAPI);
            var from = new EmailAddress("noreply@pizzeria.wiktorkowalski.pl", "PizzeriaNET");
            var subject = "Order Confirmation";
            var to = new EmailAddress(receiverEmail);
            //TODO: Add order details to email content
            var plainTextContent = "Order Confirmation";
            var htmlContent = "";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
            _logger.LogInformation($"SendGrid response: {response.StatusCode}");
        }
    }
}
