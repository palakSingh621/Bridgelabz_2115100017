using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    internal class Program7
    {
        static bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> seenNumbers = new HashSet<int>();
            foreach (int num in arr)
            {
                int complement = target - num;
                if (seenNumbers.Contains(complement))
                {
                    Console.WriteLine($"Pair Found: ({num}, {complement})");
                    return true;
                }
                seenNumbers.Add(num);
            }
            return false;
        }
        public static void Main()
        {
            int[] arr = { 10, 15, 3, 7 };
            int target = 17;
            if (!HasPairWithSum(arr, target))
            {
                Console.WriteLine("No pair found");
            }
        }
    }
}
