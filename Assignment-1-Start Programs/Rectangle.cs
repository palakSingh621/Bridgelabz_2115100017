using System;
class Rectangle
{
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter length:");
		double length = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter width:");
		double width = Convert.ToDouble(Console.ReadLine());
		double area= 2 * (length + width);
		Console.WriteLine("The area of the rectangle is :"+ area);
	}
}