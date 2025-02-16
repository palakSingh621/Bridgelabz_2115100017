using System;
using System.Text;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ConcatenateString
    {
        //Method to concatenate string array 
        public static string Concatenate(string[] words)
        {
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                result.Append(word);
            }
            return result.ToString();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the string {i + 1}: ");
                arr[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Concatenated String: " + Concatenate(arr));
        }

    }
}
