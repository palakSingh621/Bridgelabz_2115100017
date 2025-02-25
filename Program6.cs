using System;
using System.Collections.Generic;
using System.IO;
namespace CSVDataHandling
{
    internal class Program6
    {
        static void Main()
        {
            string filePath = "employees.csv";
            string updatedFilePath = "updated_employees.csv";

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

            // Reading and modifying data
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        lines.Add(line);
                        isHeader = false;
                        continue;
                    }

                    string[] values = line.Split(',');
                    if (values.Length == 4 && values[2] == "IT")
                    {
                        if (decimal.TryParse(values[3], out decimal salary))
                        {
                            salary *= 1.1m; // Increase salary by 10%
                            values[3] = salary.ToString("F2");
                        }
                    }
                    lines.Add(string.Join(",", values));
                }
            }

            // Writing updated data to a new CSV file
            using (StreamWriter writer = new StreamWriter(updatedFilePath))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine("Updated employee records saved to updated_employees.csv.");
        }
    }
}
