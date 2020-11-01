namespace PizzeriaNET.Client.WinForms.Models
{
    public class MenuItemFormModel
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
