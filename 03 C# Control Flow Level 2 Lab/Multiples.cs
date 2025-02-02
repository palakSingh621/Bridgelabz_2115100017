using System;
class Multiples
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter a number:	");
		int number = int.Parse(Console.ReadLine());

		for (int i = 100; i >= 1; i--)
		{
			if (i % number == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}