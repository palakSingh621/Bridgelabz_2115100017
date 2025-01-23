using System; 
class LeapYear
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a year: ");
		int year = Convert.ToInt32(Console.ReadLine());

		if (year >= 1582)
		{
			// Using multiple if-else statements 
			if (year % 4 == 0)
			{
				if (year % 100 == 0)
				{
					if (year % 400 == 0)
					{
						Console.WriteLine("The year is a Leap Year.");
					}
					else
					{
						Console.WriteLine("The year is not a Leap Year.");
					}
				}
				else
				{
					Console.WriteLine("The year is a Leap Year.");
				}
			}
			else
			{
				Console.WriteLine("The year is not a Leap Year.");
			}
			// Using a single if statement with multiple logical conditions
			if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
			{
				Console.WriteLine("The year is a Leap Year.");
			}
			else
			{
				Console.WriteLine("The year is not a Leap Year.");
			}
		}
		else
		{
			Console.WriteLine("The program only works for years >= 1582.");
		}
	}
}
