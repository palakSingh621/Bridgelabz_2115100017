//using System;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{
//    internal class Queue2
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter a number: ");
//            int N = Convert.ToInt32(Console.ReadLine());
//            // Generate binary numbers
//            List<string> binaryNumbers = GenerateBinaryNumbers(N);
//            Console.WriteLine("Binary Numbers: [" + string.Join(", ", binaryNumbers) + "]");
//        }
//        static List<string> GenerateBinaryNumbers(int N)
//        {
//            List<string> result = new List<string>();
//            Queue<string> queue = new Queue<string>();
//            queue.Enqueue("1");
//            for (int i = 0; i < N; i++)
//            {
//                string current = queue.Dequeue();
//                result.Add(current);
//                queue.Enqueue(current + "0");
//                queue.Enqueue(current + "1");
//            }
//            return result;
//        }
//    }
//}
