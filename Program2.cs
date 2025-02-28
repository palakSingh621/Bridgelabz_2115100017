using System;
using Newtonsoft.Json;
namespace JSONHandeling
{
    class Program2
    {
        static void Main()
        {
            // Create a Car object
            Car car = new Car { Brand = "Tesla", Model = "Model S", Year = 2023 };

            // Convert Car object to JSON format
            string carJson = JsonConvert.SerializeObject(car, Formatting.Indented);

            Console.WriteLine("Car JSON:\n" + carJson);
        }
    }

    // Car class
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
