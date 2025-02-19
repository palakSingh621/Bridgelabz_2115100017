//using System;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{
//    internal class Set3
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
//            // Compute symmetric difference
//            HashSet<int> symmetricDifferenceSet = GetSymmetricDifference(set1, set2);
//            Console.WriteLine("Symmetric Difference: {" + string.Join(", ", symmetricDifferenceSet) + "}");
//        }
//        static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
//        {
//            HashSet<int> symmetricDifference = new HashSet<int>(set1);
//            symmetricDifference.SymmetricExceptWith(set2); // Retains elements in either set but not both
//            return symmetricDifference;
//        }
//    }
//}
