using System;
using System.IO;
namespace Assignment_21_Streams
{
    class LargeFileReader
    {
        static void Main()
        {
            string filePath = "large_log.txt"; 
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    int lineNumber = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;
                        if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Console.WriteLine($"Line {lineNumber}: {line}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: The file '{filePath}' was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: An I/O error occurred - {ex.Message}");
            }
        }
    }
}
