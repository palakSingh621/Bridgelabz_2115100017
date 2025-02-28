using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JSONHandeling
{
    internal class Program14
    {
        static void Main()
        {
            // Read CSV file
            string[] csvLines = File.ReadAllLines("data.csv");

            // Extract headers
            string[] headers = csvLines[0].Split(',');

            // List to store JSON objects
            var jsonList = new List<Dictionary<string, string>>();

            // Process CSV data
            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] values = csvLines[i].Split(',');
                var jsonObj = new Dictionary<string, string>();

                for (int j = 0; j < headers.Length; j++)
                {
                    jsonObj[headers[j]] = values[j];
                }

                jsonList.Add(jsonObj);
            }

            // Convert list to JSON
            string jsonOutput = JsonConvert.SerializeObject(jsonList, Formatting.Indented);

            // Print JSON output
            Console.WriteLine("Converted JSON:\n" + jsonOutput);

            // Optionally, save JSON to a file
            File.WriteAllText("output.json", jsonOutput);
        }
    }
}
