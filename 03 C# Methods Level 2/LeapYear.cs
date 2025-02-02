using System;
class LeapYear
{
    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        // Check for leap year conditions
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
		int year=Convert.ToInt32(Console.ReadLine());
        if (year < 1582)
        {
            Console.WriteLine("The year must be 1582 or later corresponding to a year in the Gregorian calendar.");
            return;
        }
        // Check if the year is a leap year
        if (IsLeapYear(year))
        {
            Console.WriteLine(year+" is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year+" is NOT a Leap Year.");
        }
    }
}
