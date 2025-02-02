using System;
namespace Constructors_Assignment
{
    internal class Product
    {
        //Attributes
        private string productName;
        private double price;
        private static int totalProducts = 0;
        //Constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }
        //Displaying total products
        public int DisplayTotalProducts()
        {
            return totalProducts;
        }
        //Displaying product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("The name of the product: " + productName);
            Console.WriteLine("The price of the product: " + price);
            Console.WriteLine("The total number of products: " + DisplayTotalProducts());
        }
    }
    class program8
    {
        public static void Main(String[] args)
        {
            Product product1 = new Product("Shampoo", 550.00);
            product1.DisplayProductDetails();
            Console.WriteLine(" ");
            Product product2 = new Product("ToothPaste", 119.00);
            product2.DisplayProductDetails();
        }
    }
}
