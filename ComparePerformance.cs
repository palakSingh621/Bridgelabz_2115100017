using System;
using System.Text;
namespace Assignment_17_Searching_and_StringBuilder
{
    internal class ComparePerformance
    {
        public static void Main(string[] args)
        {
            long startTime, endTime;
            // Testing string Performance
            startTime = DateTime.Now.Ticks;
            string str = "C#";
            for (int i = 0; i < 100; i++)
            {
                str += "Performance Test";
            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine("String Time: " + (endTime - startTime) + " ticks");
            // Testing String Builder performance
            startTime = DateTime.Now.Ticks;
            StringBuilder sb = new StringBuilder("C#");
            for (int i = 0; i < 100; i++)
            {
                sb.Append("Performance Test");
            }
            endTime = DateTime.Now.Ticks;
            Console.WriteLine("StringBuilder Time: " + (endTime - startTime) + " ticks");
        }
    }
}
