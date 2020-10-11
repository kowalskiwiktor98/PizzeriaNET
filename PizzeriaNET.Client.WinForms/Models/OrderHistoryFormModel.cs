using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzeriaNET.Client.WinForms.Models
{
    public class OrderHistoryFormModel
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public List<OrderHistoryItemFormModel> OrderItems { get; set; }

        public override string ToString()
        {
            return $"ID:{ID} at [{Date}] - {OrderItems.Count} items, total price: {OrderItems.Sum(item => item.Price * item.Quantity)}";
        }

        public string[] GetOrderedItemsDesctiptions()
        {
            var items = new List<string>();
            items.Add(this.ToString());
            items.Add($"Comment: {Comment}");
            foreach (var item in OrderItems) items.Add(item.ToString());
            return items.ToArray();
        }
    }

    public class OrderHistoryItemFormModel
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - Quantity: {Quantity} at price {Price}";
        }
    }
}