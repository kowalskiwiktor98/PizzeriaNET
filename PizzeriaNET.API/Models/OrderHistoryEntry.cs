namespace PizzeriaNET.API.Models
{
    public class OrderHistoryEntry
    {
        public int OrderID { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}