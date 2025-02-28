using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONHandeling
{
    internal class Program6
    {
        static void Main()
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 22 },
            new Student { Name = "Bob", Age = 24 },
            new Student { Name = "Charlie", Age = 26 }
        };

            // Convert the list to JSON array format
            string jsonArray = JsonConvert.SerializeObject(students, Formatting.Indented);

            Console.WriteLine("JSON Array:\n" + jsonArray);
        }
    }

    // Student class
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
