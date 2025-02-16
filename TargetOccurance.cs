using System;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class TargetOccurance
    {
        public static int FindFirstOccurrence(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, first = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    first = mid;
                    right = mid - 1; // Continue searching in the left half
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return first;
        }
        public static int FindLastOccurrence(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, last = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    last = mid;
                    left = mid + 1; // Continue searching in the right half
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return last;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the target : ");
            int target = Convert.ToInt32(Console.ReadLine());
            int first = FindFirstOccurrence(arr, target);
            int last = FindLastOccurrence(arr, target);

            Console.WriteLine($"First Occurrence: {first}");
            Console.WriteLine($"Last Occurrence: {last}");
        }
    }
}
