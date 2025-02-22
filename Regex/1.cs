using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(Regex.IsMatch("user_123", "^[a-zA-Z][a-zA-Z0-9_]{4,14}$")); // True
        Console.WriteLine(Regex.IsMatch("123user", "^[a-zA-Z][a-zA-Z0-9_]{4,14}$")); // False
        Console.WriteLine(Regex.IsMatch("us", "^[a-zA-Z][a-zA-Z0-9_]{4,14}$")); // False
    }
}
