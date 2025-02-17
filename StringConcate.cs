using System;
using System.Diagnostics;
using System.Text;
namespace Assignment_18_Algorithms
{
    internal class StringConcate
    {
        public static void Main(string[] args)
        {
            int[] datasetSizes = { 1000, 10000, 1000000 };
            Random random = new Random();
            long stringTime;
            long builderTime;
            foreach (int size in datasetSizes)
            {
                //Testing string concatenation
                Stopwatch sw = Stopwatch.StartNew();
                string str = "";
                for (int i = 0; i < size; i++)
                {
                    str += "Test";
                }
                sw.Stop();
                stringTime = sw.ElapsedMilliseconds;
                Console.WriteLine($"Concatenation of string {size} times: {stringTime} ms");

                // Testing StringBuilder performance
                sw.Restart();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    sb.Append("Test");
                }
                sw.Stop();
                builderTime = sw.ElapsedMilliseconds;
                Console.WriteLine($"Concatenation of String Builder {size} times: {stringTime} ms");
            }
        }
    }
}
