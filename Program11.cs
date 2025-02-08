using System;
namespace Assignment_12_Inheritance
{
    // Interface
    interface IRefuelable
    {
        void Refuel();
    }
    class Vehicle
    {
        //Attributes
        public int MaxSpeed { get; set; }
        public string Model { get; set; }
        //Constructor
        public Vehicle(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }
        //show details method
        public void ShowDetails()
        {
            Console.WriteLine("Model: " + Model + ", Max Speed: " + MaxSpeed + " km/h");
        }
    }
    // Electric vehicle subclass
    class ElectricVehicle : Vehicle
    {
        //Constructor
        public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }
        //implementation of Charge
        public void Charge()
        {
            Console.WriteLine(Model + " is charging.");
        }
    }
    class PetrolVehicle : Vehicle, IRefuelable
    {
        //Constructor
        public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }
        //implementation of Refuel
        public void Refuel()
        {
            Console.WriteLine(Model + " is refueling with petrol.");
        }
    }
    internal class Program11
    {
        static void Main(string[] args)
        {
            ElectricVehicle tesla = new ElectricVehicle(200, "Tesla");
            PetrolVehicle honda = new PetrolVehicle(250, "Honda City");
            tesla.ShowDetails();
            tesla.Charge();
            honda.ShowDetails();
            honda.Refuel();
        }
    }
}
