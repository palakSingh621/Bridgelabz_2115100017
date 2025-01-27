using System;
class Circle
{
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter Radius:");
		double radius = Convert.ToDouble(Console.ReadLine());
		double area= 3.14 * radius* radius;
		Console.WriteLine("The area of the circle is :"+ area);
	}
 }