//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.RegularExpressions;
//namespace Assignment_20_Collections
//{
//    internal class Map1
//    {
//        static void Main()
//        {
//            string filePath = "input.txt";
//            Dictionary<string, int> wordFrequencies = CountWordFrequency(filePath);
//            // Print the word frequencies
//            foreach (var entry in wordFrequencies)
//            {
//                Console.WriteLine($"{entry.Key}: {entry.Value}");
//            }
//        }
//        static Dictionary<string, int> CountWordFrequency(string filePath)
//        {
//            Dictionary<string, int> wordCount = new Dictionary<string, int>();

//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("File not found.");
//                return wordCount;
//            }
//            string text = File.ReadAllText(filePath).ToLower();
//            string[] words = Regex.Split(text, @"\W+"); // Split words using non-word characters

//            foreach (string word in words)
//            {
//                if (!string.IsNullOrWhiteSpace(word))
//                {
//                    if (wordCount.ContainsKey(word))
//                        wordCount[word]++;
//                    else
//                        wordCount[word] = 1;
//                }
//            }
//            return wordCount;
//        }
//    }
//}
