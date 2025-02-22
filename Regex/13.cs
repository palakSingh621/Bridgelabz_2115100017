using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        MatchCollection prices = Regex.Matches(text, @"\$\s?\d+\.\d{2}");

        foreach (Match price in prices)
        {
            Console.WriteLine(price.Value);
        }
    }
}
