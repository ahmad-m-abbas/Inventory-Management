using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    class Driver
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Find Product");
                Console.WriteLine("6. Exit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InventoryControl.AddProduct();
                        break;
                    case "2":
                        InventoryControl.ListProducts();
                        break;
                    case "3":
                        InventoryControl.EditProduct();
                        break;
                    case "4":
                        InventoryControl.DeleteProduct();
                        break;
                    case "5":
                        InventoryControl.FindProduct();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
