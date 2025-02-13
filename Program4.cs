using System;
using System.Collections.Generic;
namespace Assignment_15_DSA2
{
    internal class Program4
    {
        static int[] SlidingWindowMaximum(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return new int[0];

            List<int> result = new List<int>();
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Remove elements from the front of the deque if they are out of the window
                if (deque.Count > 0 && deque.First.Value < i - k + 1)
                    deque.RemoveFirst();

                // Remove elements from the back if they are smaller than the current element
                while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                    deque.RemoveLast();

                // Add the current index to the deque
                deque.AddLast(i);

                // Add the maximum to the result (only after the first k elements)
                if (i >= k - 1)
                    result.Add(nums[deque.First.Value]);
            }

            return result.ToArray();
        }

        static void Main()
        {
            int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;

            int[] maxSlidingWindow = SlidingWindowMaximum(nums, k);
            Console.WriteLine("Maximum elements in each sliding window:");
            Console.WriteLine(string.Join(", ", maxSlidingWindow));
        }
    }
}
