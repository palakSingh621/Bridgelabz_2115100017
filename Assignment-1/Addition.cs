using System;
class Addition
 {
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter first number:");
		int first = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number");
		int second = Convert.ToInt32(Console.ReadLine());
		int sum= first + second;
		Console.WriteLine("Sum :"+ sum);
	}
 }