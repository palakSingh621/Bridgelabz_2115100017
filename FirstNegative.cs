using System;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class FirstNegative
    {
        //Method to find the first negative number using linear search
        public static int FindNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return arr[i];
                }
            }
            return int.MinValue;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("First Negative number: " + FindNegative(numbers));
        }
    }
}
