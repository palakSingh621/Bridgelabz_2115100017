using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace CSVDataHandling
{
    internal class Program7
    {
        static void Main()
        {
            string filePath = "employees.csv";

            // Writing data to CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary");
                writer.WriteLine("201,John Doe,IT,60000");
                writer.WriteLine("202,Jane Smith,HR,55000");
                writer.WriteLine("203,Michael Brown,Finance,70000");
                writer.WriteLine("204,Emily Davis,Marketing,65000");
                writer.WriteLine("205,David Wilson,Sales,62000");
            }

            Console.WriteLine("Employee CSV file created successfully.");

            // Reading and sorting data
            List<string[]> records = new List<string[]>();
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
                    records.Add(values);
                }
            }

            // Sorting by Salary in descending order
            var sortedRecords = records.OrderByDescending(r => decimal.Parse(r[3])).Take(5);

            Console.WriteLine("Top 5 highest-paid employees:");
            foreach (var record in sortedRecords)
            {
                Console.WriteLine($"Name: {record[1]}, Department: {record[2]}, Salary: {record[3]}");
            }
        }
    }
}
