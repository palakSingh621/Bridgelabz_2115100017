using System;
namespace Assignment_12_Inheritance
{
    internal class Device
    {
        //Attributes
        private int DeviceID { get; set; }
        private string Status { get; set; }
        //Constructor
        public Device(int deviceID, string status)
        {
            DeviceID = deviceID;
            Status = status;
        }
        //display details method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The device id is " + DeviceID);
            Console.WriteLine("The status of the device is " + Status);
        }
    }
    class Thermostat : Device
    {
        //Attribute
        private int TemperatureSetting { get; set; }

        //Constructor
        public Thermostat(int DeviceID, string Status, int temperatureSetting) : base(DeviceID, Status)
        {
            TemperatureSetting = temperatureSetting;
        }
        //Display method overriding
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Temperature Setting: " + TemperatureSetting);
        }
    }
    internal class Program5
    {
        public static void Main(String[] args)
        {
            Device device1 = new Device(1, "Inactive");
            device1.DisplayDetails();
            Thermostat thermostat1 = new Thermostat(2, "Actice", 67);
            thermostat1.DisplayDetails();
        }
    }
}
