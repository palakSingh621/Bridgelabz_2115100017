using System;

class Distance
{
	public static void Main(String [] args)
	{
		double kilometers = 10.8;
		double conversionFactor = 1.6;
		double miles = kilometers / conversionFactor;
		Console.WriteLine("The distance "+kilometers+" km in miles is "+miles);
	}
}