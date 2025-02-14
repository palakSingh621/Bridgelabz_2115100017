using System;
namespace Assignment_16_Sorting
{
    internal class HeapSort
    {
        public static void Sort(int[] salaries)
        {
            int n = salaries.Length;

            // Build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);

            // Extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                // Swap root (max element) with the last element
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;

                // Heapify the reduced heap
                Heapify(salaries, i, 0);
            }
        }
        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] salaries = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the {i + 1} Score: ");
                salaries[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(salaries);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {salaries[i]} ");
            }
        }
    }
}
