using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaNET.API.Models
{
    public class PlaceOrderRequest
    {
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
