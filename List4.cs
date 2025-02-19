using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20_Collections
{
   internal class List4
   {
       static void Main()
       {
           List<int> numbers = new List<int> ();
           Console.WriteLine("Enter the length of list: ");
           int n = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < n; i++)
           {
               numbers.Add(Convert.ToInt32(Console.ReadLine()));
           }
           // Remove duplicates while preserving order
           List<int> uniqueNumbers = RemoveDuplicates(numbers);

           Console.WriteLine("Unique List: " + string.Join(", ", uniqueNumbers));
       }
       static List<int> RemoveDuplicates(List<int> list)
       {
           HashSet<int> seen = new HashSet<int>();
           List<int> uniqueList = new List<int>();
           foreach (int num in list)
           {
               if (!seen.Contains(num))
               {
                   seen.Add(num);
                   uniqueList.Add(num);
               }
           }
           return uniqueList;
       }
   }
}
