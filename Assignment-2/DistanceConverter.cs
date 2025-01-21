using System;
class DistanceConverter
{
	public static void Main(String[] args)
	{
		double conversionFactor = 1.6;
		Console.Write("Enter distance in kilometers: ");
		double km= Convert.ToDouble(Console.ReadLine());
		double miles = km / conversionFactor;
		Console.WriteLine("The total miles is "+miles+" mile for the given "+km+" km");
	}
}