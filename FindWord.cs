using System;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class FindWord
    {
        //Method to search for the desired word using linear search
        public static string FindSentenceWithWord(string[] sentences, string word)
        {
            foreach (string sentence in sentences)
            {
                if (sentence.Contains(word))
                    return sentence;
            }
            return "Not Found";
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] sentences = new string[n];
            for (int i = 0; i < n; i++)
                sentences[i] = Console.ReadLine();
            Console.WriteLine("Enter the word to search:");
            string word = Console.ReadLine();
            Console.WriteLine(FindSentenceWithWord(sentences, word));
        }
    }
}
