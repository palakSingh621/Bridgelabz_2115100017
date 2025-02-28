using System;
using Newtonsoft.Json.Linq;
namespace JSONHandeling
{
    internal class Program1
    {
        static void Main()
        {
            // Create a JSON object for a Student
            JObject student = new JObject
            {
            { "name", "John Doe" },
            { "age", 21 },
            { "subjects", new JArray("Math", "Science", "English") }
        };

            Console.WriteLine("Student JSON: " + student);
        }
    }
}
