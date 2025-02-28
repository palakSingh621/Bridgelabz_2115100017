using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace JSONHandeling
{
    internal class Program8
    {
        static void Main()
        {
            // Read JSON file
            string jsonFromFile = File.ReadAllText("data.json");

            // Parse JSON
            JObject jsonObject = JObject.Parse(jsonFromFile);

            // Print all keys and values
            PrintJson(jsonObject, "");

        }
        static void PrintJson(JObject obj, string indent)
        {
            foreach (var property in obj.Properties())
            {
                if (property.Value is JObject nestedObject)
                {
                    Console.WriteLine($"{indent}{property.Name}:");
                    PrintJson(nestedObject, indent + "  ");
                }
                else
                {
                    Console.WriteLine($"{indent}{property.Name}: {property.Value}");
                }
            }
        }
    }
}
