using System;
using System.Diagnostics;
using System.IO;
namespace Assignment_18_Algorithms
{
    internal class FileReading
    {
        static void Main()
        {
            string filePath = "largefile.txt";
            Console.WriteLine("Reading file using StreamReader...");
            Stopwatch stopwatch = Stopwatch.StartNew();
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Read() != -1) { }
            }
            stopwatch.Stop();
            Console.WriteLine($"StreamReader Time: {stopwatch.ElapsedMilliseconds} ms\n");
            Console.WriteLine("Reading file using FileStream...");
            stopwatch.Restart();
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
            stopwatch.Stop();
            Console.WriteLine($"FileStream Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
