using System;
namespace Assignment_12_Inheritance
{
    class Vehicle
    {
        //Attributes
        private int MaxSpeed { get; set; }
        private string FuelType { get; set; }
        //Constructor
        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }
        //display details method for vehicle
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The max speed of the vehicle is " + MaxSpeed);
            Console.WriteLine("The fuel type of the vehicle is " + FuelType);
        }
    }
    class Car : Vehicle
    {
        //Attribute
        private int SeatCapacity { get; set; }
        //Constructor for Car
        public Car(int MaxSpeed, string FuelType, int seatCapacity) : base(MaxSpeed, FuelType)
        {
            SeatCapacity = seatCapacity;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The seat capacity of the car is " + SeatCapacity);
        }
    }
    class Truck : Vehicle
    {
        //Attribute
        private int PayloadCapacity { get; set; }

        //Constructor for Car
        public Truck(int MaxSpeed, string FuelType, int payloadCapacity) : base(MaxSpeed, FuelType)
        {
            PayloadCapacity = payloadCapacity;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The payload capacity of the truck is " + PayloadCapacity);
        }
    }
    class Motorcycle : Vehicle
    {
        //Attribute
        private bool HasSidecar { get; set; }
        //Constructor for Car
        public Motorcycle(int MaxSpeed, string FuelType, bool hasSidecar) : base(MaxSpeed, FuelType)
        {
            HasSidecar = hasSidecar;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            if (HasSidecar)
            {
                Console.WriteLine("The motorcycle has a sidecar");
            }
            else
            {
                Console.WriteLine("The motorcycle does not have a sidecar");
            }
        }
    }
    internal class program3
    {
        public static void Main(String[] args)
        {
            Car car1 = new Car(160, "Petrol", 7);
            Truck truck1 = new Truck(110, "Diesel", 1000);
            Motorcycle motorcycle1 = new Motorcycle(140, "Petrol", false);
            Vehicle[] vehicles = { car1, truck1, motorcycle1 };
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
