using System;
namespace Constructors_Assignment
{
    internal class CarRental
    {
        //Attributes
        private string customerName;
        private string carModel;
        private int rentalDays;
        //Constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }
        //Adding total cost
        public double totalCost()
        {
            return rentalDays * 1200;
        }
        //display details
        public void DisplayDetails()
        {
            Console.WriteLine("The name of the customer: " + customerName);
            Console.WriteLine("The model of the car: " + carModel);
            Console.WriteLine("The number of days the car is being rented: " + rentalDays);
            Console.WriteLine("The total cost for renting a car for " + rentalDays + " is: " + totalCost());
        }
        static void Main(String[] args)
        {
            CarRental car1 = new CarRental("Yash", "Toyota Fortuner", 3);
            car1.DisplayDetails();
        }
    }
}
