using System;
class Swap
{
	public static void Main(String[] args)
	{
		//Taking first number input form user
		Console.Write("Enter first number: ");
		int a= Convert.ToInt32(Console.ReadLine());
		//Taking second number input form user
		Console.Write("Enter second number: ");
		int b= Convert.ToInt32(Console.ReadLine());
		//Performing swapping
		int temp=a;
		a=b;
		b=temp;
		Console.WriteLine("The Swapped numbers are "+a+" and "+b);
	}
}