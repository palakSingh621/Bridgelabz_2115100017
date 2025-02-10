using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }
    internal abstract class Vehicle
    {
        //Attributes
        private string vehicleId;
        private string driverName;
        private double ratePerKm;
        protected string currentLocation;
        //properties for encapsulation
        public string VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }
        public double RatePerKm
        {
            get { return ratePerKm; }
            set { ratePerKm = value; }
        }
        //Constructor
        public Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
            currentLocation = "Unknown";
        }
        //abstract method to calculate fare
        public abstract double CalculateFare(double distance);
        //concrete method to get vehicle details
        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID " + vehicleId);
            Console.WriteLine("Driver Name " + driverName);
            Console.WriteLine("Rate per Km " + ratePerKm);
            Console.WriteLine("Current Location " + currentLocation);
        }
    }
    class Car : Vehicle, IGPS
    {
        public Car(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            double fare = distance * RatePerKm;
            Console.WriteLine("The fare for the car ride is " + fare);
            return fare;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Car current location " + currentLocation);
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
            Console.WriteLine("Car location updated to " + location);
        }
    }
    class Bike : Vehicle, IGPS
    {
        public Bike(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            double fare = distance * RatePerKm * 0.8; //20% discount for bike rides
            Console.WriteLine("The fare for the bike ride is " + fare);
            return fare;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Bike current location " + currentLocation);
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
            Console.WriteLine("Bike location updated to " + location);
        }
    }

    class Auto : Vehicle, IGPS
    {
        public Auto(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            double fare = distance * RatePerKm * 0.9; //10% discount for auto rides
            Console.WriteLine("The fare for the auto ride is " + fare);
            return fare;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Auto current location " + currentLocation);
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
            Console.WriteLine("Auto location updated to " + location);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("C101", "Jitendra", 15),
                new Bike("B202", "Jailesh", 10),
                new Auto("A303", "Mikka", 12)
            };
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                vehicle.CalculateFare(20);
                if (vehicle is IGPS gpsEnabledVehicle)
                {
                    gpsEnabledVehicle.UpdateLocation("City Center");
                    gpsEnabledVehicle.GetCurrentLocation();
                }
                Console.WriteLine();
            }
        }
    }
}
