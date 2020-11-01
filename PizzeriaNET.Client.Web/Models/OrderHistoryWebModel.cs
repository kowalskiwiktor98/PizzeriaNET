using System;
using System.Collections.Generic;

namespace PizzeriaNET.Client.Web.Models
{
    public class OrderHistoryWebModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public List<OrderHistoryItemWebModel> OrderItems { get; set; }
    }

    public class OrderHistoryItemWebModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
