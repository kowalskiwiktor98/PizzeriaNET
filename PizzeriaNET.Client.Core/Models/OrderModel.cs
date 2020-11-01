using System;
using System.Collections.Generic;

namespace PizzeriaNET.Client.Core.Models
{
    public class OrderModel
    {
        public bool SendEmailNotification { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime OrderTime { get; set; }
        public IEnumerable<OrderItemModel> OrderedItems { get; set; }
    }

    public class OrderItemModel
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
    }
}
