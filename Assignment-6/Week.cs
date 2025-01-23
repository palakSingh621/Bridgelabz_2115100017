using System;
class Week
{
	public static void Main(String [] args)
	{
		Console.Write("Enter the day");
		int day = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the month");
		int month = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the year");
		int year = Convert.ToInt32(Console.ReadLine());
		
		int y = year - (14 - month)/12;
		int x = y + y/4 - y/100 + y/400;
		int m = month + 12 * ((14 - month)/12) - 2;
		int d = (day + x + 31 * m /12 ) % 7;
		
		Console.WriteLine("The day is "+d);
	}
}
