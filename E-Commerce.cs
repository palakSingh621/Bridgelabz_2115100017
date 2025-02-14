using System;
namespace Assignment_16_Sorting
{
    internal class E_Commerce
    {
        //Method to sort the product prices using quick sort
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }
        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high], i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int t = arr[j];
                    arr[j] = arr[i];
                    arr[i] = t;
                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;
            return i + 1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] prices = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the {i + 1} Book Price: ");
                prices[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(prices, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" {prices[i]} ");
            }
        }
    }
}
