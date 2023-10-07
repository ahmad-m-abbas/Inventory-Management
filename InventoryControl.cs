using Inventory_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class InventoryControl
    {
        static List<Product> Products = new List<Product>();

        private static string getName()
        {
            string name;

            do
            {
                Console.WriteLine("Enter the name of Product you want to edit:");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("This string is not valid");
                }

            } while (string.IsNullOrEmpty(name));

            return name;
        }
        public static void AddProduct()
        {
            string name;
            Console.WriteLine("Please Enter Product information, to terminate, just enter -1");

            do
            {
                Console.WriteLine("Write the Product name:");
                name = Console.ReadLine();

                if (name.Equals("-1"))
                {
                    return;
                }

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Product name cannot be empty");
                }

            } while(string.IsNullOrEmpty(name));

            Decimal price;

            do
            {
                Console.Write("Write price of the product:");
                if (decimal.TryParse(Console.ReadLine(), out price))
                {
                    if (price == -1)
                    {
                        return;
                    }

                    if (price < 0)
                    {
                        Console.WriteLine("Price must be positive");
                    }
                }
                else
                {
                    Console.WriteLine("You muse enter a number");
                }
            } while (price < 0);


            int quantity;
            do
            {
                Console.Write("Write the producrt quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity))
                {

                    if (quantity == -1)
                    {
                        return;
                    }


                    if (quantity < 0)
                    {
                        Console.WriteLine("Quantity must be positive.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid quantity.");
                }
            } while (quantity < 0);

            Product product = new Product(name, price, quantity);
            Products.Add(product);
        }

        public static void ListProducts()
        {
            if(Products.Count == 0)
            {
                Console.WriteLine("No Products to Print");
                return;
            }

            Console.WriteLine("Products:");
            Console.WriteLine("**********************************************************");
            foreach (Product product in Products)
            {
                Console.WriteLine($"{product.Name}, {product.Price}, {product.Quantity}");
            }
            Console.WriteLine("**********************************************************");

        }
        public static void EditProduct()
        {

            string name = getName();

            Product product = Products.Find(Product => Product.Name == name);

            if (product == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the number of the thing you want to edit");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Price");
                Console.WriteLine("3. Quantity");
                Console.WriteLine("4. Done Editing");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new product name: ");
                        product.Name = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Enter new product price: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal newPrice) && newPrice > 0)
                            product.Price = newPrice;
                        else
                            Console.WriteLine("Invalid input");
                        break;
                    case "3":
                        Console.Write("Enter new product quantity: ");
                        if (int.TryParse(Console.ReadLine(), out int newQuantity) && newQuantity > 0)
                            product.Quantity = newQuantity;
                        else
                            Console.WriteLine("Invalid input");
                        break;
                    case "4":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Select a valid option.");
                        break;
                }
            }
        }
        public static void DeleteProduct()
        {
            string name = getName();

            Product product = Products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            Products.Remove(product);
            Console.WriteLine($"Product {product} has been deleted.");
        }
    }
}
