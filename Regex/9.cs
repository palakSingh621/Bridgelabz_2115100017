using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        string output = Regex.Replace(input, @"(damn|stupid)", "****");
        Console.WriteLine(output);
    }
}
