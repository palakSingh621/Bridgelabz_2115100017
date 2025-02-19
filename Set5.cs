using System;
using System.Collections.Generic;
namespace Assignment_20_Collections
{
   internal class Set5
   {
       static void Main()
       {
           HashSet<int> mainSet = new HashSet<int>();
           Console.WriteLine("Enter the length of mainset: ");
           int n1 = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < n1; i++)
           {
               mainSet.Add(Convert.ToInt32(Console.ReadLine()));
           }
           HashSet<int> subset = new HashSet<int>();
           Console.WriteLine("Enter the length of subset: ");
           int n2 = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < n2; i++)
           {
               subset.Add(Convert.ToInt32(Console.ReadLine()));
           }
           // Check if subset is a subset of mainSet
           bool isSubset = IsSubset(subset, mainSet);
           Console.WriteLine("Is Subset? " + isSubset);
       }
       static bool IsSubset(HashSet<int> subset, HashSet<int> mainSet)
       {
           return mainSet.IsSupersetOf(subset);
       }
   }
}
