using System;
namespace Assignment_16_Sorting
{
    internal class Student
    {
        //Method to sort the array using Bubble sort
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the {i + 1} number: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(marks);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {marks[i]} ");
            }
        }
    }
}
