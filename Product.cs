using System;
using System.Runtime.CompilerServices;
namespace Assignment_10
{
    internal class Product
    {
        //attributes
        static int discount=15;
        string productName;
        double price;
        int quantity;
        readonly int productID;
        //Constructor
        public Product(int productID, string productName, double price, int quantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price; 
            this.quantity = quantity;   
        }
        //Method to Update disount using getter setter
        public static int UpdateDiscount
        {
            get { return discount ; }
            set { discount = value ; }
        }
        //method to display products
        public void DisplayProduct() 
        {
            if(this is Product)
            {
                Console.WriteLine("Product Id:" + productID);
                Console.WriteLine("Product Name: " + productName);
                Console.WriteLine("Product Price: "+price);
                Console.WriteLine("Quantity: "+quantity);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Incorrect Object Instance");
            }
        }
    }
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Discount Percentage on products: " + Product.UpdateDiscount);
            Console.WriteLine();
            Product product_1 = new Product(01, "Bottle", 580.00, 3);
            product_1.DisplayProduct();
            Console.WriteLine("Updating the discount percentage to 20% ");
            Product.UpdateDiscount = 20;
            Console.WriteLine();
            Console.WriteLine("New Discount Percentage on products: " + Product.UpdateDiscount);
        }
    }
}
