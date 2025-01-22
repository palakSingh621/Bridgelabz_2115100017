using System;
class TemperatureConversionInF
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the temperature in Celsius: ");
		double tempInCelcius= Convert.ToDouble(Console.ReadLine());
		// Converting temperature in celcius to Fahrenheit
		double tempInFahrenheit= (tempInCelcius * 9/5)+32;
		Console.WriteLine("The "+tempInCelcius+" Celsius is "+tempInFahrenheit+" Fahrenheit");
	}
}