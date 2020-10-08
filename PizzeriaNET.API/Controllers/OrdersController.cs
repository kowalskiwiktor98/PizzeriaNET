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

        public OrdersController(ILogger<OrdersController> logger, IDatabaseHelper databaseHelper, INotificationService notificationService)
        {
            _logger = logger;
            _databaseHelper = databaseHelper;
            _notificationService = notificationService;
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
            await _databaseHelper.InsertOrder(placeOrderRequest);
            await _notificationService.SendConfirmEmail(placeOrderRequest.Email);
            return Ok();
        }

        [HttpGet]
        [Route("GetOrderHistory")]
        public async Task<ActionResult> GetOrderHistory([FromQuery] string email)
        {
            var orderHistory = await _databaseHelper.SelectOrderHistory(email);
            return Ok(orderHistory);
        }
    }
}
