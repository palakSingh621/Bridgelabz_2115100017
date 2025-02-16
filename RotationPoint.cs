using System;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class RotationPoint
    {
        public static int FindRotationPoint(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while(left< right)
            {
                int mid= left +(right-left)/2;
                if (arr[mid] > arr[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Rotation Point index: " + FindRotationPoint(arr));
        }
    }
}
