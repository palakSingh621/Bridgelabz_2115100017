using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    interface ITaxable
    {
        void CalculateTax();
        void GetTaxDetails();
    }
    internal abstract class Product
    {
        //Attributes
        protected string productID { get; }
        protected string name { get; set; }
        protected double price { get; set; }
        protected double taxAmount { get; set; }

        //Constructor
        public Product(string productID, string name, double price)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
        }

        //abstract method to calculate discount
        public abstract void CalculateDiscount();
    }

    class Electronics : Product, ITaxable
    {
        //Constructor
        public Electronics(string productID, string name, double price) : base(productID, name, price)
        {

        }

        public override void CalculateDiscount()
        {
            double discount = price * 10 / 100;
            price -= discount;
            Console.WriteLine("The price of the electronic " + name + " with the product id " + productID + " is " + price);
        }

        public void CalculateTax()
        {
            taxAmount = price * 18 / 100;
            price += taxAmount;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax for " + name + " is " + taxAmount);
        }
    }

    class Clothing : Product, ITaxable
    {
        //Constructor
        public Clothing(string productID, string name, double price) : base(productID, name, price)
        {

        }

        public override void CalculateDiscount()
        {
            double discount = price * 20 / 100;
            price -= discount;
            Console.WriteLine("The price of the cloth " + name + " with the product id " + productID + " is " + price);
        }

        public void CalculateTax()
        {
            taxAmount = price * 10 / 100;
            price += taxAmount;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax for " + name + " is " + taxAmount);
        }
    }

    class Groceries : Product, ITaxable
    {
        //Constructor
        public Groceries(string productID, string name, double price) : base(productID, name, price)
        {

        }

        public override void CalculateDiscount()
        {
            double discount = price * 15 / 100;
            price -= discount;
            Console.WriteLine("The price of the grocery " + name + " with the product id " + productID + " is " + price);
        }

        public void CalculateTax()
        {
            taxAmount = price * 5 / 100;
            price += taxAmount;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax for " + name + " is " + taxAmount);
        }
    }

    internal class program2
    {
        public static void Main(String[] args)
        {
            List<Product> products = new List<Product> {
                new Groceries("101","Flour",109),
                new Electronics("102","Air pods",10999),
                new Clothing("103","Bape Hoodie",6999),
            };

            foreach (Product product in products)
            {
                if (product is ITaxable taxableProduct)
                {
                    taxableProduct.CalculateTax();
                    taxableProduct.GetTaxDetails();
                }

                product.CalculateDiscount();
                Console.WriteLine();
            }
        }
    }
}
