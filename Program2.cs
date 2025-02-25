using System;
using System.IO;
namespace CSVDataHandling
{
    internal class Program2
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
        }
    }
}
