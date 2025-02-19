//using System;
//using System.Collections;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{ 
//    internal class List1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the length: ");
//            int n=Convert.ToInt32(Console.ReadLine());
//            ArrayList arrayList = new ArrayList();
//            for(int i=0;i<n;i++)
//            {
//                arrayList.Add(Convert.ToInt32(Console.ReadLine()));
//            }
//            ReverseArrayList(arrayList);
//            Console.WriteLine("Reverse ArrayList: ");
//            foreach (int v in arrayList)
//            {
//                Console.WriteLine(v);
//            }
//            LinkedList<int> linkedList = new LinkedList<int>();
//            Console.WriteLine("Enter LinkedList: ");
//            for(int i=0; i<n;i++)
//            {
//                linkedList.AddLast(Convert.ToInt32(Console.ReadLine()));
//            }
//            linkedList = ReverseLinkedList(linkedList);
//            Console.Write("Reversed LinkedList: ");
//            foreach (int val in linkedList)
//            {
//                Console.Write(val + " ");
//            }
//        }
//        public static void ReverseArrayList(ArrayList arrayList)
//        {
//            int left = 0;
//            int right = arrayList.Count - 1;
//            while (left < right)
//            {
//                object temp = arrayList[left];
//                arrayList[left] = arrayList[right];
//                arrayList[right] = temp;
//                left++;
//                right--;
//            }
//        }
//        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
//        {
//            LinkedList<int> reversedList = new LinkedList<int>();
//            foreach (int item in list)
//            {
//                reversedList.AddFirst(item); // Adds each item to the beginning
//            }
//            return reversedList;
//        }
//    }
//}
