using System;
class Average
{
	public static void Main(String [] args)
	{
		 Console.WriteLine("Enter first number:");
		 double first = Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("Enter second number:");
		 double second = Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("Enter Third number:");
		 double third = Convert.ToDouble(Console.ReadLine());
		 double average= (first + second + third)/3;
		 Console.WriteLine("Average :"+ average);
	}
}