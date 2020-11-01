using System;
using System.Collections.Generic;

namespace PizzeriaNET.API.Models
{
    public class OrderHistory
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public List<OrderHistoryItem> OrderItems { get; set; }
    }

    public class OrderHistoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
