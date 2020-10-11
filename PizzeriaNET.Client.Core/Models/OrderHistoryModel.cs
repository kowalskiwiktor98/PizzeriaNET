using System;
using System.Collections.Generic;

namespace PizzeriaNET.Client.Core.Models
{
    public class OrderHistoryModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public List<OrderHistoryItemModel> OrderItems { get; set; }
    }

    public class OrderHistoryItemModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}