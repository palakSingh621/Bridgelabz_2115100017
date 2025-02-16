using System;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ChallangeProgram
    {
        // Function to find the first missing positive integer using Linear Search
        public static int FindFirstMissingPositive(int[] arr)
        {
            int n = arr.Length;

            // Step 1: Place numbers in correct indices
            for (int i = 0; i < n; i++)
            {
                while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
                {
                    // Swap arr[i] with arr[arr[i] - 1]
                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                }
            }

            // Step 2: Identify the missing positive integer
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != i + 1)
                    return i + 1; // Missing positive integer
            }

            return n + 1; // If all numbers are in order, return next positive integer
        }

        // Function to perform binary search
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid; // Target found
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Target not found
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
            // Find the first missing positive number
            int missingPositive = FindFirstMissingPositive((int[])arr.Clone()); // Clone to avoid modifying original
            // Sort the array for binary search
            Array.Sort(arr);
            // Perform binary search for the target
            int targetIndex = BinarySearch(arr, target);
            Console.WriteLine($"First Missing Positive Integer: {missingPositive}");
            Console.WriteLine($"Index of Target {target}: {targetIndex}");
        }
    }
}
