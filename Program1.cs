using System;
using System.IO;
namespace Assignment_21_Exceptions
{
    class Program1
    {
        static void Main()
        {
            string filePath = "data.txt";

            try
            {
                // Attempt to read the file
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Contents:\n" + content);
            }
            catch (FileNotFoundException)
            {
                // Handle file not found exception
                Console.WriteLine("File not found");
            }
            catch (IOException ex)
            {
                // Handle other IO exceptions
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
            }
        }
    }
}
