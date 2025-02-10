using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    interface IInsurable
    {
        void CalculateInsurance();
        void GetInsuranceDetails();
    }

    internal abstract class Vehicle1
    {
        //Attributes
        private string vehicleNumber;
        private string type;
        private double rentalRate;
        private string insurancePolicyNumber;
        protected double insuranceAmount;

        //properties for encapsulation
        public string VehicleNumber { get; set; }
        public string Type { get; set; }
        public double RentalRate { get; set; }

        public string InsurancePolicyNumber
        {
            get { return "[Restricted]"; }
            private set { insurancePolicyNumber = value; }
        }

        //constructor
        public Vehicle1(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
            insurancePolicyNumber = "POLICY" + new Random().Next(1000, 9999);
        }

        //abstract method to calculate rental cost
        public abstract void CalculateRentalCost(double days);

        //concrete method to get vehicle details
        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle1 Number " + VehicleNumber);
            Console.WriteLine("Type " + Type);
            Console.WriteLine("Rental Rate per Day " + RentalRate);
        }
    }

    class Car1 : Vehicle1, IInsurable
    {
        public Car1(string vehicleNumber, string type, double rentalRate) : base(vehicleNumber, type, rentalRate) { }

        public override void CalculateRentalCost(double days)
        {
            double cost = days * RentalRate;
            Console.WriteLine("The rental cost for the car is " + cost);
        }

        public void CalculateInsurance()
        {
            insuranceAmount = RentalRate * 0.2;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance for the car is " + insuranceAmount);
        }
    }

    class Bike1 : Vehicle1, IInsurable
    {
        public Bike1(string vehicleNumber, string type, double rentalRate) : base(vehicleNumber, type, rentalRate) { }

        public override void CalculateRentalCost(double days)
        {
            double cost = days * RentalRate * 0.9; //10% discount for bikes
            Console.WriteLine("The rental cost for the bike is " + cost);
        }

        public void CalculateInsurance()
        {
            insuranceAmount = RentalRate * 0.1;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance for the bike is " + insuranceAmount);
        }
    }
    class Truck1 : Vehicle1, IInsurable
    {
        public Truck1(string vehicleNumber, string type, double rentalRate) : base(vehicleNumber, type, rentalRate) { }
        public override void CalculateRentalCost(double days)
        {
            double cost = days * RentalRate * 1.5; //trucks have 50% higher rates
            Console.WriteLine("The rental cost for the truck is " + cost);
        }
        public void CalculateInsurance()
        {
            insuranceAmount = RentalRate * 0.3;
        }
        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance for the truck is " + insuranceAmount);
        }
    }
    class Program3
    {
        public static void Main(string[] args)
        {
            List<Vehicle1> vehicles = new List<Vehicle1>
            {
                new Car1("C101", "Sedan", 50),
                new Bike1("B202", "Sports Bike", 30),
                new Truck1("T303", "Heavy Truck", 100)
            };
            foreach (Vehicle1 vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                vehicle.CalculateRentalCost(5);
                if (vehicle is IInsurable insurableVehicle)
                {
                    insurableVehicle.CalculateInsurance();
                    insurableVehicle.GetInsuranceDetails();
                }
                Console.WriteLine();
            }
        }
    }
}
