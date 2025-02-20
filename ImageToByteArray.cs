using System;
using System.Collections;
using System.IO;
namespace Assignment_21_Streams
{
    class ImageToByteArray
    {
        static void Main()
        {
            string inputFile = "input.jpg"; 
            string outputFile = "output.jpg"; 
            try
            {
                // Convert Image to ByteArray
                byte[] imageData = ConvertImageToByteArray(inputFile);

                // Convert ByteArray back to Image
                WriteByteArrayToImage(outputFile, imageData);

                // Verify if both files are identical
                if (VerifyFiles(inputFile, outputFile))
                    Console.WriteLine("The files are identical.");
                else
                    Console.WriteLine("The files are different.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File I/O error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static byte[] ConvertImageToByteArray(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (MemoryStream ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    Console.WriteLine("Image converted to byte array successfully.");
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Error converting image to byte array: {ex.Message}");
            }
        }

        static void WriteByteArrayToImage(string outputFilePath, byte[] imageData)
        {
            try
            {
                using (FileStream fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(imageData, 0, imageData.Length);
                    Console.WriteLine("Byte array written back to image file successfully.");
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Error writing byte array to image file: {ex.Message}");
            }
        }

        static bool VerifyFiles(string file1, string file2)
        {
            try
            {
                byte[] file1Bytes = File.ReadAllBytes(file1);
                byte[] file2Bytes = File.ReadAllBytes(file2);

                return StructuralComparisons.StructuralEqualityComparer.Equals(file1Bytes, file2Bytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error verifying files: {ex.Message}");
                return false;
            }
        }
    }
}
