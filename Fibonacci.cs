using System;
using System.Diagnostics;
namespace Assignment_18_Algorithms
{
    internal class Fibonacci
    {
        public static int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        public static int FibonacciIterative(int n)
        {
            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
        public static void Main(string[] args)
        {
            long recursionTime;
            long iterationTime;
            Console.WriteLine("Enter the number: ");
            int n=Convert.ToInt32(Console.ReadLine());
            // Fibonacci Series using Recursion
            Console.WriteLine("series using recursion: ");
            Stopwatch sw = Stopwatch.StartNew();
            FibonacciRecursive(n);
            sw.Stop();
            recursionTime= sw.ElapsedMilliseconds;
            Console.WriteLine($"Time taken: {recursionTime} ms");
            // Fibonacci Series uding Iteration
            Console.WriteLine("series using iteration: ");
            sw.Restart();
            FibonacciIterative(n);
            sw.Stop();
            iterationTime = sw.ElapsedMilliseconds;
            Console.WriteLine($"Time taken: {iterationTime} ms");
            if (iterationTime < recursionTime)
            {
                Console.WriteLine("Recursive approach is infeasible for large values of N due to exponential growth. The iterative approach is significantly faster and memory-efficient.");
            }
        }
    }
}
