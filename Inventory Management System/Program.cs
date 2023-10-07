
namespace Inventory_Management
{
    class Product
    {
        string Name { get; set;}
        decimal Price { get; set;}
        int Quantity { get; set;}

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

    }
}