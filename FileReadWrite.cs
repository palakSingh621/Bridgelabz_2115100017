using System;
using System.IO;
namespace Assignment_21_Streams
{
    internal class FileReadWrite
    {
        static void Main()
        {
            Console.Write("Enter source file path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter destination file path: ");
            string destinationFile = Console.ReadLine();

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                // Open FileStreams for reading and writing
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024]; // Buffer for efficient reading
                    int bytesRead;
                    // Read and write in chunks
                    while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsWrite.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("File copied successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
