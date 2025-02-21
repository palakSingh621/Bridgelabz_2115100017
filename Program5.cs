using System;
using System.IO;
namespace Assignment_21_Exceptions
{
    class Program5
    {
        static void Main()
        {
            string filePath = "info.txt";
            try
            {
                // Using statement ensures the file is automatically closed
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine("First Line: " + firstLine);
                }
            }
            catch (IOException)
            {
                // Handle file-related exceptions
                Console.WriteLine("Error reading file");
            }
        }
    }
}
