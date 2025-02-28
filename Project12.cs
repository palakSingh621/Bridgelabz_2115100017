using System;
using System.IO;
using Newtonsoft.Json.Linq;
namespace JSONHandeling
{
    internal class Project12
    {
        static void Main()
        {
            // Read JSON files
            string json1 = File.ReadAllText("file1.json");
            string json2 = File.ReadAllText("file2.json");

            // Parse JSON objects
            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            // Merge JSON objects
            obj1.Merge(obj2, new JsonMergeSettings
            {
                MergeArrayHandling = MergeArrayHandling.Union
            });

            // Convert merged object to formatted JSON string
            string mergedJson = obj1.ToString();

            // Print merged JSON
            Console.WriteLine("Merged JSON:\n" + mergedJson);

            // Optionally, save merged JSON to a file
            File.WriteAllText("merged.json", mergedJson);
        }
    }
}
