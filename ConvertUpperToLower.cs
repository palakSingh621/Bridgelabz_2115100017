using System;
using System.IO;
using System.Text;
namespace Assignment_21_Streams
{
    class ConvertUpperToLower
    {
        static void Main()
        {
            string inputFile = "input.txt";   // Source file
            string outputFile = "output.txt"; // Destination file

            try
            {
                ConvertFileToLowercase(inputFile, outputFile);
                Console.WriteLine("File conversion completed successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File I/O error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static void ConvertFileToLowercase(string inputFile, string outputFile)
        {
            if (!File.Exists(inputFile))
            {
                Console.WriteLine("Error: The input file does not exist.");
                return;
            }

            try
            {
                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                using (BufferedStream bsInput = new BufferedStream(fsInput))
                using (StreamReader reader = new StreamReader(bsInput, Encoding.UTF8))

                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsOutput = new BufferedStream(fsOutput))
                using (StreamWriter writer = new StreamWriter(bsOutput, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.ToLower()); // Convert to lowercase before writing
                    }
                }

                Console.WriteLine("Successfully converted uppercase letters to lowercase.");
            }
            catch (Exception ex)
            {
                throw new IOException($"Error processing file: {ex.Message}");
            }
        }
    }
}
