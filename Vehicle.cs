using System;
namespace Constructors_Assignment
{
    internal class Vehicle
    {
        //Attributes
        private string ownerName;
        private string vehicleType;
        private static double registrationFee = 1000.00;
        //Constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        //Updating registration fee
        public static void UpdateRegistrationFee()
        {
            Console.Write("Enter the new registration fee: ");
            double newRegistrationFee = Convert.ToDouble(Console.ReadLine());
            registrationFee = newRegistrationFee;
        }
        //Display all details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("The name of the owner: " + ownerName);
            Console.WriteLine("The vehicle type: " + vehicleType);
            Console.WriteLine("The registration fee: " + registrationFee);
        }
    }
    public class program10
    {
        public static void Main(String[] args)
        {
            Vehicle vehicle1 = new Vehicle("Ashish", "Four Wheeler");
            vehicle1.DisplayVehicleDetails();
            Console.WriteLine(" ");
            Vehicle.UpdateRegistrationFee();
            vehicle1.DisplayVehicleDetails();
        }
    }
}

