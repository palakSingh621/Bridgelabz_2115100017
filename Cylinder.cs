 using System;
 class Cylinder
 {
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter radius:");
		double radius = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter height:");
		double height = Convert.ToDouble(Console.ReadLine());
		double volume= 3.14 * radius* radius * height;
		Console.WriteLine("The volume of the cylinder is :"+ volume);
	}
 }