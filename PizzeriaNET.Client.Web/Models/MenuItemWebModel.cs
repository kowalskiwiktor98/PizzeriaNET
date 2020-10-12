using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaNET.Client.Web.Models
{
    public class MenuItemWebModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return $"[{Category}] {Name}";
        }
    }
}
