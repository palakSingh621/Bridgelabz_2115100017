using System;
class Volume
{
	public static void Main(String[] args)
	{
		double radiusKm = 6378;
		double kmToMiles = 0.621371;
		double volumeKm3 = (4.0 /3.0) * Math.PI * Math.Pow(radiusKm, 3);
		double volumeMiles3 =volumeKm3 * Math.Pow(kmToMiles, 3);
		Console.WriteLine("The volume of Earth in cubic kilometers is "+volumeKm3.ToString("F2")+" and in cubic miles is "+volumeMiles3.ToString("F2"));
	}
}