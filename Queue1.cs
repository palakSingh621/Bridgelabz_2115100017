using System;
using System.Collections.Generic;
namespace Assignment_20_Collections
{
   internal class Queue1
   {
       static void Main()
       {
           Queue<int> queue = new Queue<int>();
           Console.WriteLine("Enter the length of queue: ");
           int n = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < n; i++)
           {
               queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
           }
           // Reverse the queue
           Queue<int> reversedQueue = ReverseQueue(queue);
           Console.WriteLine("Reversed Queue: [" + string.Join(", ", reversedQueue) + "]");
       }
       static Queue<int> ReverseQueue(Queue<int> queue)
       {
           Stack<int> stack = new Stack<int>();
           // Dequeue all elements and push them onto the stack
           while (queue.Count > 0)
           {
               stack.Push(queue.Dequeue());
           }
           // Pop from the stack and enqueue back into the queue
           while (stack.Count > 0)
           {
               queue.Enqueue(stack.Pop());
           }
           return queue;
       }
   }
}
