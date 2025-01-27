using System;
class Kilometer
{
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter distance in kilometers :");
		double distance = Convert.ToDouble(Console.ReadLine());
		double miles= distance * 0.621371;
		Console.WriteLine("The distance in miles :"+ miles);
	}
}