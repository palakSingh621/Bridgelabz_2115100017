using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    internal class Program6
    {
        static void FindSubarray(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum == 0)
                {
                    Console.WriteLine($"Subarray found form 0 to {i}");
                }
                if (map.ContainsKey(sum))
                {
                    foreach (var start in map[sum])
                    {
                        Console.WriteLine($"Subarray found from {start + 1} to {i}");
                    }
                }
                if (!map.ContainsKey(sum))
                {
                    map[sum] = new List<int>();
                }
                map[sum].Add(i);
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 4, 2, -3, 1, 6 };
            FindSubarray(arr);
        }
    }
}
