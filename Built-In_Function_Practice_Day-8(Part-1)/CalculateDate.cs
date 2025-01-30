using System;
class CalculateDate
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a date in yyyy-MM-dd format: ");
		DateTime inputDate=Convert.ToDateTime(Console.ReadLine());
		// Adding 7 days, 1 month and 2 years
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        modifiedDate = modifiedDate.AddDays(-21); // Subtracting 3 weeks
		Console.WriteLine("Modified Date: "+modifiedDate);
    }
}