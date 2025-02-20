using System;
using System.Diagnostics;
using System.IO;
namespace Assignment_21_Streams
{
    internal class BufferedFileCopy
    {
        static void Main()
        {
            Console.Write("Enter source file path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter destination file path for BufferedStream copy: ");
            string bufferedDestFile = Console.ReadLine();

            Console.Write("Enter destination file path for Unbuffered copy: ");
            string unbufferedDestFile = Console.ReadLine();

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Error: Source file does not exist.");
                    return;
                }

                // Measure time for BufferedStream copy
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                CopyUsingBufferedStream(sourceFile, bufferedDestFile);
                stopwatch.Stop();
                Console.WriteLine($"BufferedStream Copy Time: {stopwatch.ElapsedMilliseconds} ms");

                // Measure time for Normal FileStream copy
                stopwatch.Reset();
                stopwatch.Start();
                CopyUsingFileStream(sourceFile, unbufferedDestFile);
                stopwatch.Stop();
                Console.WriteLine($"Unbuffered FileStream Copy Time: {stopwatch.ElapsedMilliseconds} ms");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void CopyUsingBufferedStream(string source, string destination)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsRead = new BufferedStream(fsRead, 4096))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite, 4096))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }

        static void CopyUsingFileStream(string source, string destination)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
