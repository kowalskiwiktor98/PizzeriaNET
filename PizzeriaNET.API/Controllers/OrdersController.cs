using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PizzeriaNET.API.Database;
using PizzeriaNET.API.Models;
using PizzeriaNET.API.Services;

namespace PizzeriaNET.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IDatabaseHelper _databaseHelper;
        private readonly INotificationService _notificationService;
        private readonly IOrderParserHelper _orderParserHelper;

        public OrdersController(ILogger<OrdersController> logger, IDatabaseHelper databaseHelper, INotificationService notificationService, IOrderParserHelper orderParserHelper)
        {
            _logger = logger;
            _databaseHelper = databaseHelper;
            _notificationService = notificationService;
            _orderParserHelper = orderParserHelper;
        }

        [HttpPost]
        [Route("PlaceOrder")]
        public async Task<ActionResult> PlaceOrder(PlaceOrderRequest placeOrderRequest)
        {
            _logger.LogInformation("PlaceOrder request");
            if (string.IsNullOrWhiteSpace(placeOrderRequest.Email))
            {
                _logger.LogWarning("Bad Request: Email is empty");
                return BadRequest("Bad Request: Email is empty");
            }

            try
            {
                var orderEntries = await _databaseHelper.InsertOrder(placeOrderRequest);
                if (placeOrderRequest.SendEmailNotification)
                {
                    var order = _orderParserHelper.ParseNewOrder(orderEntries);
                    await _notificationService.SendConfirmEmail(order, placeOrderRequest.Email);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500);
            }

            return Ok();
        }

        [HttpGet]
        [Route("GetOrderHistory")]
        public async Task<ActionResult> GetOrderHistory([FromQuery] string email)
        {
            _logger.LogInformation("GetOrderHistory request");
            var orderHistoryEntries = await _databaseHelper.SelectOrderHistory(email);
            var orderHistory = _orderParserHelper.ParseOrderHistory(orderHistoryEntries);
            return Ok(orderHistory);
        }
    }
}
