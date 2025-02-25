using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace CSVDataHandling
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
        }
    }
    internal class Program9
    {
        static void Main()
        {
            string filePath = "students.csv";

            // Writing data to CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Age,Marks");
                writer.WriteLine("101,John Doe,20,85");
                writer.WriteLine("102,Jane Smith,22,78");
                writer.WriteLine("103,Michael Brown,21,92");
                writer.WriteLine("104,Emily Davis,23,75");
                writer.WriteLine("105,David Wilson,19,88");
            }

            Console.WriteLine("Student CSV file created successfully.");

            // Reading data and converting to Student objects
            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] values = line.Split(',');
                    students.Add(new Student
                    {
                        ID = int.Parse(values[0]),
                        Name = values[1],
                        Age = int.Parse(values[2]),
                        Marks = int.Parse(values[3])
                    });
                }
            }

            // Printing student objects
            Console.WriteLine("Students List:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
