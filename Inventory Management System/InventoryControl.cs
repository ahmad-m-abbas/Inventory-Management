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

    }
}
