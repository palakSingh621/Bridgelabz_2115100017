using System;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class Matrix
    {
        //Method to search for target element from the matrix
        static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = matrix[mid / cols, mid % cols];

                if (midValue == target) return true;
                else if (midValue < target) left = mid + 1;
                else right = mid - 1;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows of array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns of array: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the target number: ");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SearchMatrix(arr, target));
        }
    }
}
