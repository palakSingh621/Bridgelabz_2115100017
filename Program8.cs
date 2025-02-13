using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    internal class Program8
    {
        static int LongestConsecutiveSequence(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(arr);
            int longestStreak = 0;
            foreach (int num in arr)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }
            return longestStreak;
        }
        static void Main()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine("Length of longest consecutive sequence: " + LongestConsecutiveSequence(arr));
        }
    }
}
