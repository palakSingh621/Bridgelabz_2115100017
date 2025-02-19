using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20_Collections
{
    class ShoppingCart
    {
        private Dictionary<string, double> productPrices = new Dictionary<string, double>(); // Stores products and their prices
        private LinkedList<string> cartOrder = new LinkedList<string>(); // Maintains order of added items
        private SortedDictionary<string, double> sortedCart = new SortedDictionary<string, double>(); // Stores items sorted by name

        public void AddProduct()
        {
            Console.Write("Enter product name: ");
            string product = Console.ReadLine();
            Console.Write("Enter product price: ");

            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
            {
                Console.WriteLine("Invalid price! Try again.");
                return;
            }

            if (productPrices.ContainsKey(product))
            {
                Console.WriteLine("Product already in cart. Updating price.");
            }
            productPrices[product] = price;
            cartOrder.AddLast(product);

            Console.WriteLine($"{product} added to cart successfully!");
        }

        public void DisplayCart()
        {
            Console.WriteLine("\nShopping Cart (Original Order):");
            foreach (var product in cartOrder)
            {
                Console.WriteLine($"{product}: ${productPrices[product]:F2}");
            }
        }

        public void DisplaySortedCart()
        {
            sortedCart = new SortedDictionary<string, double>(productPrices);
            Console.WriteLine("\nShopping Cart (Sorted by Product Name):");
            foreach (var item in sortedCart)
            {
                Console.WriteLine($"{item.Key}: ${item.Value:F2}");
            }
        }

        public void DisplaySortedByPrice()
        {
            var sortedByPrice = productPrices.OrderBy(x => x.Value);
            Console.WriteLine("\nShopping Cart (Sorted by Price):");
            foreach (var item in sortedByPrice)
            {
                Console.WriteLine($"{item.Key}: ${item.Value:F2}");
            }
        }
    }
    internal class Shopping
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("\nShopping Cart Menu");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Cart (Original Order)");
                Console.WriteLine("3. View Cart (Sorted by Name)");
                Console.WriteLine("4. View Cart (Sorted by Price)");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        cart.AddProduct();
                        break;
                    case "2":
                        cart.DisplayCart();
                        break;
                    case "3":
                        cart.DisplaySortedCart();
                        break;
                    case "4":
                        cart.DisplaySortedByPrice();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
