using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org";
        MatchCollection emails = Regex.Matches(text, @"[\w.-]+@[\w.-]+\.[a-zA-Z]{2,6}");

        foreach (Match email in emails)
        {
            Console.WriteLine(email.Value);
        }
    }
}
