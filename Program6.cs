using System;
namespace Assignment_12_Inheritance
{
    internal class Order
    {
        //Attribute
        private int OrderID { get; set; }
        private DateTime OrderDate { get; set;}
        //Constructor
        public Order(int orderID, DateTime orderDate)
        {
            OrderID = orderID;
            OrderDate = orderDate;
        }

        //get order status method
        public virtual void GetOrderStatus()
        {
            Console.WriteLine("The order Id of the order is " + OrderID);
            Console.WriteLine("It was Ordered on " + OrderDate);
        }
    }

    class ShippedOrder : Order
    {
        //Attribute
        private int TrackingNumber { get; set; }

        //Constructor
        public ShippedOrder(int OrderID, DateTime OrderDate, int trackingNumber) : base(OrderID, OrderDate)
        {
            TrackingNumber = trackingNumber;
        }

        //method to get order status
        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine("The tracking number of the shipped order is" + TrackingNumber);
        }
    }

    class DeliveredOrder : ShippedOrder
    {
        //Attributes
        private DateTime DeliveryDate { get; set; }

        //Constructor
        public DeliveredOrder(int OrderID, DateTime OrderDate, int TrackingNumber, DateTime deliveryDate) : base(OrderID, OrderDate, TrackingNumber)
        {
            DeliveryDate = deliveryDate;
        }

        //method to view order status
        public override void GetOrderStatus()
        {
            base.GetOrderStatus();
            Console.WriteLine("The package was delivered on " + DeliveryDate);
        }
    }
    internal class Program6
    {
        public static void Main(String[] args)
        {
            DateTime orderDate = new DateTime(2002, 2, 8);
            Order order1 = new Order(1, orderDate);
            order1.GetOrderStatus();

            ShippedOrder so1 = new ShippedOrder(1, orderDate, 784);
            so1.GetOrderStatus();


            DateTime deliveryDate = new DateTime(2002, 6, 8);
            DeliveredOrder do1 = new DeliveredOrder(1, orderDate, 784, deliveryDate);
            do1.GetOrderStatus();
        }
    }
}
