using System;
class TimeAndDate
{
    public static void Main(String[] args)
    {
        // Get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        Console.WriteLine("UTC Time: "+utcNow+" UTC");

        DisplayTimeInTimeZone(utcNow, "GMT Standard Time", "GMT (Greenwich Mean Time)");
        DisplayTimeInTimeZone(utcNow, "India Standard Time", "IST (Indian Standard Time)");
        DisplayTimeInTimeZone(utcNow, "Pacific Standard Time", "PST (Pacific Standard Time)");
    }

    public static void DisplayTimeInTimeZone(DateTimeOffset utcNow, string timeZoneId, string label)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTimeOffset localTime = TimeZoneInfo.ConvertTime(utcNow, timeZone);
        Console.WriteLine(label+": "+localTime+" "+timeZone.StandardName);
    }
}