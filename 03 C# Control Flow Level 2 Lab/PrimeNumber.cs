using System;
class PrimeNumber
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		if (number > 1)
		{
		bool isPrime = true;
			for (int i = 2; i <= number / 2; i++)
			{
				if (number % i == 0)
				{
					isPrime = false; 
					break;
				}
			}
			// Checking for prime number.
			if (isPrime)
			{
				Console.WriteLine(number + " is a prime number.");
			}
			else
			{
				Console.WriteLine(number + " is not a prime number.");
			}
		}
		else
		{
			Console.WriteLine("Prime number checks are done for numbers greater than 1.");
		}
	}
}