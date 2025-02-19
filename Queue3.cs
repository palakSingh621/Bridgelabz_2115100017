using System;
using System.Collections.Generic;
namespace Assignment_20_Collections
{
    internal class Queue3
    {
        static void Main()
        {
            PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>(Comparer<int>.Create((x, y) => y - x));

            triageQueue.Enqueue("Palak", 3);
            triageQueue.Enqueue("Al Jazir", 5);
            triageQueue.Enqueue("Bobby", 2);

            Console.WriteLine("Order of treatment:");

            while (triageQueue.Count > 0)
            {
                Console.WriteLine(triageQueue.Dequeue());
            }
        }
    }
}
