using System;
using System.IO;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ReaderCount
    {
        public static void Main(string[] args)
        {
            string filePath = "sample.txt";
            Console.WriteLine("Enter the target word: ");
            string target = Convert.ToString(Console.ReadLine());
            int count = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Equals(target, StringComparison.OrdinalIgnoreCase))
                            count++;
                    }
                }
            }
            Console.WriteLine($"The Word '{target}' appears {count} times.");
        }
    }
}
