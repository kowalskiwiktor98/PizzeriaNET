using System;
using System.Collections.Generic;

namespace PizzeriaNET.API.Models
{
    public class PlaceOrderRequest
    {
        public bool SendEmailNotification { get; set; } = false;
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime OrderTime { get; set; }
        public IEnumerable<OrderedItem> OrderedItems { get; set; }
    }

    public class OrderedItem
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    }
}
