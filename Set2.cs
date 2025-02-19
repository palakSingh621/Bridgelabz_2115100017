//using System;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{
//    internal class Set2
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
//            // Compute union and intersection
//            HashSet<int> unionSet = GetUnion(set1, set2);
//            HashSet<int> intersectionSet = GetIntersection(set1, set2);
//            // Print results
//            Console.WriteLine("Union: {" + string.Join(", ", unionSet) + "}");
//            Console.WriteLine("Intersection: {" + string.Join(", ", intersectionSet) + "}");
//        }
//        static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2)
//        {
//            HashSet<int> unionSet = new HashSet<int>(set1);
//            unionSet.UnionWith(set2); // Adds elements from set2 that are not already in set1
//            return unionSet;
//        }
//        static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
//        {
//            HashSet<int> intersectionSet = new HashSet<int>(set1);
//            intersectionSet.IntersectWith(set2); // Retains only elements that are in both sets
//            return intersectionSet;
//        }
//    }
//}
