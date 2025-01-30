using System;
class CompareDates
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the first date in format yyyy-MM-dd: ");
		DateTime date1= Convert.ToDateTime(Console.ReadLine());
		Console.Write("Enter the second date in format yyyy-MM-dd: ");
		DateTime date2= Convert.ToDateTime(Console.ReadLine());
		int value =date1.CompareTo(date2); 
        // checking 
        if (value > 0) 
            Console.WriteLine("date1 is later than date2. "); 
        else if (value < 0) 
            Console.WriteLine("date1 is earlier than date2. "); 
        else
            Console.WriteLine("date1 is the same as date2. ");  
	}
}