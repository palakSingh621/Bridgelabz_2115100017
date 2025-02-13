using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    internal class Program10
    {
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numIndexMap.ContainsKey(complement))
                    return new int[] { numIndexMap[complement], i };

                numIndexMap[nums[i]] = i;
            }

            return new int[] { };
        }

        static void Main()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);
            if (result.Length > 0)
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            else
                Console.WriteLine("No pair found.");
        }
    }
}
