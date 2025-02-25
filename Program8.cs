using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace CSVDataHandling
{
    internal class Program8
    {
        static void Main()
        {
            string filePath = "employees.csv";

            // Writing data to CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary,Email,Phone");
                writer.WriteLine("201,John Doe,IT,60000,john.doe@example.com,9876543210");
                writer.WriteLine("202,Jane Smith,HR,55000,jane.smith@example,12345"); // Invalid email and phone
                writer.WriteLine("203,Michael Brown,Finance,70000,michael.brown@example.com,9876543211");
                writer.WriteLine("204,Emily Davis,Marketing,65000,emily.davis@example.com,98765432"); // Invalid phone
                writer.WriteLine("205,David Wilson,Sales,62000,david.wilson@example.com,9876543212");
            }

            Console.WriteLine("Employee CSV file created successfully.");

            // Reading and validating data
            List<string[]> records = new List<string[]>();
            Regex emailRegex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            Regex phoneRegex = new Regex(@"^\d{10}$");

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
                    bool isValid = true;

                    if (!emailRegex.IsMatch(values[4]))
                    {
                        Console.WriteLine($"Invalid Email: {values[4]} in record {string.Join(",", values)}");
                        isValid = false;
                    }
                    if (!phoneRegex.IsMatch(values[5]))
                    {
                        Console.WriteLine($"Invalid Phone Number: {values[5]} in record {string.Join(",", values)}");
                        isValid = false;
                    }

                    if (isValid)
                    {
                        records.Add(values);
                    }
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
