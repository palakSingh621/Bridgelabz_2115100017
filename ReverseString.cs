using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ReverseString
    {
        //Method to reverse the string
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            String s = Convert.ToString(Console.ReadLine());
            StringBuilder sb = new StringBuilder(s);
            sb = new StringBuilder(Reverse(sb.ToString()));
            Console.WriteLine(sb);
        }
    }
}
