using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace JSONHandeling
{
    internal class Program3
    {
        static void Main()
        {
            // Read JSON file
            string jsonFromFile = File.ReadAllText("data.json");

            // Parse JSON array
            JArray jsonArray = JArray.Parse(jsonFromFile);

            // Extract and display name and email fields
            foreach (var item in jsonArray)
            {
                Console.WriteLine($"Name: {item["name"]}, Email: {item["email"]}");
            }
        }
    }
}
