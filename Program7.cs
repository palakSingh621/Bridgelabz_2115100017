using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JSONHandeling
{
    internal class Program7
    {
        static void Main()
        {
            // JSON string (simulating reading from a file or API)
            string jsonString = @"[
            { 'name': 'Alice', 'age': 22 },
            { 'name': 'Bob', 'age': 24 },
            { 'name': 'Charlie', 'age': 26 },
            { 'name': 'David', 'age': 28 }
        ]";

            // Parse JSON array
            JArray jsonArray = JArray.Parse(jsonString);

            // Filter records where age > 25
            var filteredRecords = jsonArray.Where(obj => (int)obj["age"] > 25);

            // Convert to JSON format and print
            string filteredJson = JsonConvert.SerializeObject(filteredRecords, Formatting.Indented);
            Console.WriteLine("Filtered JSON (Age > 25):\n" + filteredJson);
        }
    }
}
