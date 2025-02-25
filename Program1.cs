using System;
using System.IO;
namespace CSVDataHandling
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            string filePath = "students.csv";  

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    Console.WriteLine("ID	Name	Age	Marks");
                    Console.WriteLine("--------------------------------");
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 4)
                        {
                            Console.WriteLine($"{values[0]}	{values[1]}	{values[2]}	{values[3]}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("CSV file not found.");
            }
        }
    }
}
