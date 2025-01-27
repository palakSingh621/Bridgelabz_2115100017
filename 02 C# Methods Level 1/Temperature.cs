using System;
class Temperature
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the temperature: ");
		double temp=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the wind speed: ");
		double windSpeed=Convert.ToDouble(Console.ReadLine());
		Temperature t=new Temperature();
		Console.WriteLine("Wind Chill: "+t.CalculateWindChill(temp, windSpeed));
	}
	public double CalculateWindChill(double temperature, double windSpeed)
	{
		// Calculating Wind Chill using formula
		double windChill= 35.74+0.6215*temperature+(0.4275*temperature-35.75)*windSpeed*0.16;
		return windChill;
	}
}