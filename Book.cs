using System;
namespace Assignment_16_Sorting
{
    internal class Book
    {
        //Methods to sort the price of books using merge Sort
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int leftLength = mid - left + 1;
            int rightLength = right - mid;
            int[] leftArray = new int[leftLength];
            int[] rightArray = new int[rightLength];
            int i, j;
            for (i = 0; i < leftLength; i++)
            {
                leftArray[i] = arr[i + left];
            }
            for (j = 0; j < rightLength; j++)
            {
                rightArray[j] = arr[mid + j + 1];
            }
            i = 0;
            j = 0;
            int k = left;
            while (i < leftLength && j < rightLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k++] = leftArray[i++];
                }
                else
                {
                    arr[k++] = rightArray[j++];
                }
            }
            while (i < leftLength)
            {
                arr[k++] = leftArray[i++];
            }
            while (j < rightLength)
            {
                arr[k++] = rightArray[j++];
            }
        }
        static void Main(string[] args)
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
