
namespace Inventory_Management
{
    class Product
    {
        public string Name { get; set;}
        public decimal Price { get; set;}
        public int Quantity { get; set;}

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

    }
}