using System;
using System.IO;
namespace Assignment_21_Streams
{
    internal class UserInputFile
    {
        static void Main()
        {
            string filePath = "UserData.txt"; // File to store user input

            try
            {
                Console.WriteLine("Enter your Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your Age:");
                string age = Console.ReadLine();

                Console.WriteLine("Enter your Favorite Programming Language:");
                string language = Console.ReadLine();

                // Writing to file
                using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
                {
                    writer.WriteLine($"Name: {name}");
                    writer.WriteLine($"Age: {age}");
                    writer.WriteLine($"Favorite Language: {language}");
                    writer.WriteLine(new string('-', 30)); // Separator
                }

                Console.WriteLine("User information saved successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
