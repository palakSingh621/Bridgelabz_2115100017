using System;
using System.IO;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ByteToChar
    {
        public static void Main(string[] args)
        {
            string filePath = "binaryfile.dat";

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("File content:\n" + content);
            }
        }
    }
}
