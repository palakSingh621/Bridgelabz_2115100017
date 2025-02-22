using System;
namespace Nunit_Assignment
{
    public class StringUtils
    {
        // Method to reverse a string
        public string Reverse(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to check if a string is a palindrome
        public bool IsPalindrome(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            string reversed = Reverse(str);
            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }

        // Method to convert a string to uppercase
        public string ToUpperCase(string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));
            return str.ToUpper();
        }
    }
}
