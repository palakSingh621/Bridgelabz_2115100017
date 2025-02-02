using System;
class DistanceInMilesFeet
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the distance in feet: ");
		double distanceInFeet = Convert.ToDouble(Console.ReadLine());
		double feetToYards = 1.0/3.0;
		double yardsToMiles = 1.0/1760.0;
		double distanceInYards= distanceInFeet * feetToYards;
		double distanceInMiles = distanceInYards * yardsToMiles;
		Console.WriteLine("The distance in yards is "+distanceInYards.ToString("F2")+" and in miles is "+distanceInMiles.ToString("F2")+" for the given "+distanceInFeet.ToString("F2")+" feet.");
	}
}