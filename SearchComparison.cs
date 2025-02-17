using System;
using System.Diagnostics;
namespace Assignment_18_Algorithms
{
    internal class SearchComparison
    {
        static void Main(string[] args)
        {
            int[] datasetSizes = { 1000, 10000, 1000000 };
            Random random = new Random();
            foreach (int size in datasetSizes)
            {
                long binaryTime;
                long linearTime;
                int[] data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    data[i] = random.Next(1, size * 10);
                }
                int target = data[random.Next(size)];

                //Linear Search
                Stopwatch stopwatch = Stopwatch.StartNew();
                int linearIndex = LinearSearch(data, target);
                stopwatch.Stop();
                linearTime = stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Linear Search in {size} elements: {linearTime} ms");
                //Binary Search
                Array.Sort(data);
                stopwatch.Restart();
                int binaryIndex = BinarySearch(data, target);
                stopwatch.Stop();
                binaryTime = stopwatch.ElapsedMilliseconds;
                Console.WriteLine($"Binary Search in {size} elements: {binaryTime} ms");
                if (linearTime > binaryTime)
                {
                    Console.WriteLine("Binary Search performs much better for large datasets, provided data is sorted.");
                }
            }
        }
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid;
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
            return -1;
        }
    }
}
