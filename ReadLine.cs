using System;
using System.IO;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ReadLine
    {
        public static void Main(string[] args)
        {
            string filePath = "sample.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while(( line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
