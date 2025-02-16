using System;
using System.IO;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ReadAndWrite
    {
        public static void Main(String[] args)
        {
            string filePath = "Input.txt";

            Console.WriteLine("Enter text to write to file (type 'exit' to stop):");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string input;
                while ((input = Console.ReadLine()) != "exit")
                {
                    writer.WriteLine(input);
                }
            }

            Console.WriteLine("Data written to file successfully.");
        }
    }
}
