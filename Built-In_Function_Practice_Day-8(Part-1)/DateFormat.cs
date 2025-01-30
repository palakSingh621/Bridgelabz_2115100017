using System;
class DateFormat
{
	public static void Main(String[] args)
	{	// Getting current Date
		DateTime now=DateTime.Now;
		Console.WriteLine("Format 1: "+now.ToString("dd/MM/yyyy"));
		Console.WriteLine("Format 2: "+now.ToString("yyyy-MM-dd"));
		Console.WriteLine("Format 3: "+now.ToString("MMM dd,yyyy"));
	}
}