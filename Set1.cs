//using System;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{
//    internal class Set1
//    {
//        static void Main()
//        {
//            HashSet<int> set1 = new HashSet<int>();
//            Console.WriteLine("Enter the length of set1: ");
//            int n1 = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n1; i++)
//            {
//                set1.Add(Convert.ToInt32(Console.ReadLine()));
//            }
//            HashSet<int> set2 = new HashSet<int>();
//            Console.WriteLine("Enter the length of set2: ");
//            int n2 = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n2; i++)
//            {
//                set2.Add(Convert.ToInt32(Console.ReadLine()));
//            }
//            // Check if sets are equal
//            bool areEqual = AreSetsEqual(set1, set2);
//            Console.WriteLine("Are Sets Equal? " + areEqual);
//        }

//        static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
//        {
//            return set1.SetEquals(set2);
//        }
//    }
//}
