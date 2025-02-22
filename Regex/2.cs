using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(Regex.IsMatch("AB1234", "^[A-Z]{2}\\d{4}$")); // True
        Console.WriteLine(Regex.IsMatch("A12345", "^[A-Z]{2}\\d{4}$")); // False
    }
}
