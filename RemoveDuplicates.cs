using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class RemoveDuplicates
    {
        public static string RemoveDuplicate(string s)
        {
            StringBuilder result = new StringBuilder();
            HashSet<char> set = new HashSet<char>();
            foreach (char c in s)
            {
                if (!set.Contains(c))
                {
                    set.Add(c);
                    result.Append(c);
                }
            }
            return result.ToString();
            {

            }
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string s = Console.ReadLine();
            Console.WriteLine("String after removing duplicates: " + RemoveDuplicate(s));
        }
    }
}
