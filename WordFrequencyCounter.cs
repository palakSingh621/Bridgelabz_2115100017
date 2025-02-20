using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace Assignment_21_Streams
{
    class WordFrequencyCounter
    {
        static void Main()
        {
            string filePath = "sample.txt";
            try
            {
                Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Remove punctuation and split into words
                        string[] words = Regex.Replace(line, @"[^\w\s]", "").ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }
                // Sort words by frequency in descending order
                var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);
                Console.WriteLine("Total unique words: " + wordCount.Count);
                Console.WriteLine("\nTop 5 Most Frequent Words:");
                foreach (var word in topWords)
                {
                    Console.WriteLine($"{word.Key}: {word.Value} times");
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
