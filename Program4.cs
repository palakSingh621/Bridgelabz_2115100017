using System;
using System.IO;
namespace CSVDataHandling
{
    internal class Program4
    {
        static void Main()
        {
            string filePath = "students.csv";

            // Writing data to CSV file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Age,Marks");
                writer.WriteLine("101,John Doe,20,85");
                writer.WriteLine("102,Jane Smith,21,78");
                writer.WriteLine("103,Michael Brown,22,90");
                writer.WriteLine("104,Emily Davis,19,76");
                writer.WriteLine("105,David Wilson,23,88");
            }

            Console.WriteLine("Student CSV file created successfully.");

            // Reading and filtering records
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;
                Console.WriteLine("ID	Name	Age	Marks");
                Console.WriteLine("------------------------------");
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    string[] values = line.Split(',');
                    if (values.Length == 4 && int.TryParse(values[3], out int marks) && marks > 80)
                    {
                        Console.WriteLine($"{values[0]}	{values[1]}	{values[2]}	{values[3]}");
                    }
                }
            }
        }
    }
}
