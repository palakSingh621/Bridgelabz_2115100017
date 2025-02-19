//using System;
//using System.Collections.Generic;
//namespace Assignment_20_Collections
//{
//    internal class List2
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the length of list: ");
//            int n= Convert.ToInt32 (Console.ReadLine());
//            List<string> items = new List<string> ();
//            for(int i=0;i<n;i++)
//            {
//                items.Add (Console.ReadLine ());
//            }
//            // Get frequency dictionary
//            Dictionary<string, int> frequency = GetFrequency(items);
//            foreach (var item in frequency)
//            {
//                Console.WriteLine($"{item.Key}: {item.Value}");
//            }
//        }

//        static Dictionary<string, int> GetFrequency(List<string> items)
//        {
//            Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

//            foreach (string item in items)
//            {
//                if (frequencyDict.ContainsKey(item))
//                {
//                    frequencyDict[item]++;
//                }
//                else
//                {
//                    frequencyDict[item] = 1;
//                }
//            }

//            return frequencyDict;
//        }
//    }
//}
