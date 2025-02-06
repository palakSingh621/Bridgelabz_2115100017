using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    // Product class
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        //product constructor
        public Product(int id, string name, decimal price)
        {
            Random random = new Random();
            Id = random.Next(1,1000);
            Name = name;
            Price = price;
        }
    }
    // Order class representing a customer's order
    class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
        //Constructor
        public Order(int orderId, Customer customer)
        {
            Random random=new Random();
            OrderId = random.Next(1,1000);
            Customer = customer;
            Products = new List<Product>();
            OrderDate = DateTime.Now;
        }
        //Method to add the product
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        //Method to calculate the total price of products
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }

    // Customer class representing a user of the platform
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(int customerId, string name)
        {
            Random random= new Random();
            CustomerId = random.Next(1,1000);
            Name = name;
            Orders = new List<Order>();
        }
        //Method to place Order 
        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }
    }       
    internal class E_Commerce
    {
        static void Main()
        {
            // Creating products
            Product laptop = new Product(1, "Laptop", 1200.00m);
            Product phone = new Product(2, "Smartphone", 800.00m);
            Product headphones = new Product(3, "Headphones", 150.00m);
            // Creating a customer
            Customer customer = new Customer(101, "Palak");
            // Creating an order for the customer
            Order order = new Order(1001, customer);
            order.AddProduct(laptop);
            order.AddProduct(phone);
            // Placing the order
            customer.PlaceOrder(order);
            // Display order details
            Console.WriteLine($"Customer: {customer.Name} placed an order (Order ID: {order.OrderId})");
            Console.WriteLine("Products in the order: ");
            foreach (var product in order.Products)
            {
                Console.WriteLine($"{product.Name}: Rs.{product.Price}");
            }
            Console.WriteLine($"Total Price: Rs.{order.GetTotalPrice()}");
            Console.WriteLine();
        }
    }
}
