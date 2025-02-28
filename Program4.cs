using System;
using Newtonsoft.Json.Linq;
namespace JSONHandeling
{
    internal class Program4
    {
        static void Main()
        {
            // Define two JSON objects
            JObject obj1 = JObject.Parse("{ \"name\": \"Alice\" }");
            JObject obj2 = JObject.Parse("{ \"age\": 30 }");

            // Merge obj2 into obj1
            obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            Console.WriteLine("Merged JSON: " + obj1);
        }
    }
}
