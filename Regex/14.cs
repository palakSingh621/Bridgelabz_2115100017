using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        MatchCollection repeats = Regex.Matches(text, @"\b(\w+)\s+\1\b");

        foreach (Match repeat in repeats)
        {
            Console.WriteLine(repeat.Groups[1].Value);
        }
    }
}
