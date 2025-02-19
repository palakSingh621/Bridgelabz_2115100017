//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_20_Collections
//{
//    internal class set4
//    {
//        static void Main()
//        {
//            HashSet<int> set = new HashSet<int>();
//            Console.WriteLine("Enter the length of set: ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                set.Add(Convert.ToInt32(Console.ReadLine()));
//            }
//            // Convert to sorted list
//            List<int> sortedList = ConvertToSortedList(set);
//            Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
//        }
//        static List<int> ConvertToSortedList(HashSet<int> set)
//        {
//            List<int> sortedList = new List<int>(set); // Convert HashSet to List
//            sortedList.Sort(); // Sort in ascending order
//            return sortedList;
//        }
//    }
//}
