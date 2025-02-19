//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_20_Collections
//{
//    internal class List5
//    {
//        static void Main()
//        {
//            LinkedList<char> linkedList = new LinkedList<char>();
//            Console.WriteLine("Enter the length of list: ");
//            int v = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < v; i++)
//            {
//                linkedList.AddLast(Convert.ToChar(Console.ReadLine()));
//            }
//            Console.WriteLine("Enter the position form last: ");
//            int N = Convert.ToInt32(Console.ReadLine());
//            // Find Nth node from the end
//            char result = FindNthFromEnd(linkedList, N);
//            Console.WriteLine("Nth Element from End: " + result);
//        }
//        static char FindNthFromEnd(LinkedList<char> list, int N)
//        {
//            LinkedListNode<char> first = list.First;
//            LinkedListNode<char> second = list.First;
//            for (int i = 0; i < N; i++)
//            {
//                first = first.Next;
//            }
//            while (first != null)
//            {
//                first = first.Next;
//                second = second.Next;
//            }
//            return second.Value;
//        }
//    }
//}
