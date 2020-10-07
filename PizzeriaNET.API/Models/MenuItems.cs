using Microsoft.AspNetCore.Mvc;

namespace PizzeriaNET.API.Models
{
    public class MenuItems
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
    }
}