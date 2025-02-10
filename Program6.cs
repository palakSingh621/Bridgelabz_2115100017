using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    interface IDiscountable
    {
        void ApplyDiscount();
        void GetDiscountDetails();
    }

    internal abstract class FoodItem
    {
        //Attributes
        protected string itemName { get; set; }
        protected double price { get; set; }
        protected int quantity { get; set; }
        protected double discountAmount { get; set; }

        //Constructor
        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        //concrete method to get item details
        public void GetItemDetails()
        {
            Console.WriteLine("The name of the product is " + itemName);
            Console.WriteLine("The price of the product is " + price);
            Console.WriteLine("The quantity of the product is " + quantity);
        }

        //abstract method 
        public abstract void CalculateTotalPrice();
    }

    class VegItem : FoodItem, IDiscountable
    {
        //calling parent class constructor using base()
        public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity)
        {

        }

        //method overriding to calculate total price of veg items
        public override void CalculateTotalPrice()
        {
            double totalPrice = (20 + price) * quantity;
            Console.WriteLine("The total price for all the items is " + totalPrice);
        }

        public void ApplyDiscount()
        {
            discountAmount = price * 0.1; // 10% discount
            price -= discountAmount;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("The discount applied to " + itemName + " is " + discountAmount);
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        //calling parent class constructor using base()
        public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity)
        {

        }

        //method overriding to calculate total price of non-veg items
        public override void CalculateTotalPrice()
        {
            double totalPrice = (30 + price) * quantity;
            Console.WriteLine("The total price for all the items is " + totalPrice);
        }

        public void ApplyDiscount()
        {
            discountAmount = price * 0.15; //15% discount
            price -= discountAmount;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("The discount applied to " + itemName + " is " + discountAmount);
        }
    }

    class program6
    {
        public static void Main(String[] args)
        {
            List<FoodItem> fooditems = new List<FoodItem> {
                new VegItem("Chilli potato", 60, 12),
                new NonVegItem("Chicken Tikka", 100, 20),
            };

            foreach (FoodItem fooditem in fooditems)
            {
                fooditem.GetItemDetails();
                Console.WriteLine();
                if (fooditem is IDiscountable discountableItem)
                {
                    discountableItem.ApplyDiscount();
                    discountableItem.GetDiscountDetails();
                }
                Console.WriteLine();
                fooditem.CalculateTotalPrice();
            }
        }
    }
}
