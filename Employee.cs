using System;
namespace Assignment_16_Sorting
{
    internal class Employee
    {
        // Methos to sort employee ids using insertion sort
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > arr[j + 1])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ids = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the {i + 1} ID: ");
                ids[i] = Convert.ToInt32(Console.ReadLine());
            }
            InsertionSort(ids);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {ids[i]} ");
            }
        }
    }
}
