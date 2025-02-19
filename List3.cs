//using System;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{
//    internal class List3
//    {
//        public static void Main(string[] args) 
//        {
//            List<int> number = new List<int>();
//            Console.WriteLine("Enter the length of list: ");
//            int n= Convert.ToInt32(Console.ReadLine());
//            for(int i=0;i<n;i++)
//            {
//                number.Add(Convert.ToInt32(Console.ReadLine()));
//            }
//            Console.WriteLine("Enter the rotation value: ");
//            int rotation= Convert.ToInt32(Console.ReadLine());
//            List<int> rotatedList= RotateList(number,rotation);
//            Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
//        }
//        public static List<int> RotateList(List<int> list, int positions)
//        {
//            int n = list.Count;
//            positions = positions % n; // Handling cases where positions > list size
//            List<int> rotated = new List<int>();
//            rotated.AddRange(list.GetRange(positions, n - positions));
//            rotated.AddRange(list.GetRange(0, positions));

//            return rotated;
//        }
//    }
//}
