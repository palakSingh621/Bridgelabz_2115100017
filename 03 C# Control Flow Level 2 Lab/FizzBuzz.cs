using System;
class FizzBuzz
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a positive integer:");
		int number = Convert.ToInt32(Console.ReadLine());

		if (number > 0)
		{
			for (int i = 1; i <= number; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
		else
		{
			Console.WriteLine("Please enter a positive integer.");
		}
	}
}