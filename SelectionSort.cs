using System;
namespace Assignment_16_Sorting
{
    internal class SelectionSort
    {
        public static void Sort(int[] scores)
        {
            int n = scores.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = scores[minIndex];
                scores[minIndex] = scores[i];
                scores[i] = temp;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] scores = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the {i + 1} Score: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(scores);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {scores[i]} ");
            }
        }
    }
}
