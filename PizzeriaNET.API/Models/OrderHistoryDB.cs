using System;

namespace PizzeriaNET.API.Models
{
    public class OrderHistoryDB
    {
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}