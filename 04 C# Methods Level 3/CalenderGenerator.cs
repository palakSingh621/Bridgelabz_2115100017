using System;
public class CalendarGenerator
{
    private static string[] months = {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    };

    private static int[] daysInMonth = {
        31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
    };

    public static string GetMonthName(int month)
    {
        if (month >= 1 && month <= 12)
            return months[month - 1];
        return "Invalid Month";
    }

    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public static int GetDaysInMonth(int month, int year)
    {
        if (month == 2 && IsLeapYear(year))
            return 29;
        return daysInMonth[month - 1];
    }

    public static int GetFirstDayOfMonth(int month, int year)
    {
        // Implementation of Gregorian calendar algorithm
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0/4 - y0/100 + y0/400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7;
        return d0;
    }

    public static void DisplayCalendar(int month, int year)
    {
        // Display month and year
        Console.WriteLine("\n      " + GetMonthName(month) + " " + year);
        
        // Display the days header
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Get first day of the month
        int startDay = GetFirstDayOfMonth(month, year);
        
        // Get number of days in the month
        int daysInCurrentMonth = GetDaysInMonth(month, year);

        // First loop for initial spaces
        for (int i = 0; i < startDay; i++)
        {
            Console.Write("   ");
        }

        // Second loop for days
        for (int day = 1; day <= daysInCurrentMonth; day++)
        {
            Console.Write("{0,3}", day);
            
            // Move to next line if it's Saturday (end of week)
            if ((day + startDay) % 7 == 0 || day == daysInCurrentMonth)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        try
        {
            Console.Write("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month. Please enter a value between 1 and 12.");
                return;
            }

            if (year < 1)
            {
                Console.WriteLine("Invalid year. Please enter a positive value.");
                return;
            }

            DisplayCalendar(month, year);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
