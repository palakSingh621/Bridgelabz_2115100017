using System;
namespace Assignment_10
{
    internal class Vehicle
    {
        //attributes
        static double registrationFee= 2000.00;
        string owerName;
        string vehicleType;
        readonly int registrationNumber;
        //constructor
        public Vehicle(string ownerName, string vehicleType, int registrationNumber)
        {
            this.owerName = ownerName; 
            this.vehicleType = vehicleType;
            this.registrationNumber = registrationNumber;
        }
        //Method to Update Registration Fees
        public static void UpdateRegisterationFee(double value)
        {
            registrationFee = value;
        }
        // get method for registration fees
        public static double GetRegistrationFee()
        {
            return registrationFee;
        }
        // Display method for vehicle details
        public void displayVehicle()
        {
            Console.WriteLine("Owner Name: "+owerName);
            Console.WriteLine("Vehicle Type: "+vehicleType);
            Console.WriteLine("Registration Number: " + registrationNumber);
            Console.WriteLine();
        }
    }
    class Program6
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Palak", "Two Wheeler", 654321);
            Vehicle v2 = new Vehicle("Pramod", "Four Wheeler", 987654);
            v1.displayVehicle();
            v2.displayVehicle();
            Console.WriteLine("Registration fees: " + Vehicle.GetRegistrationFee());
            Console.WriteLine("Updating Registration Fees....");
            Vehicle.UpdateRegisterationFee(7000.00);
            Console.WriteLine("New Registration fees: " + Vehicle.GetRegistrationFee());
        }
    }
}
