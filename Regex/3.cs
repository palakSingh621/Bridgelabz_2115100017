using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(Regex.IsMatch("#FFA500", "^#[0-9A-Fa-f]{6}$")); // True
        Console.WriteLine(Regex.IsMatch("#123", "^#[0-9A-Fa-f]{6}$")); // False
    }
}
