using System;
class TemperatureConversionInC
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the temperature in Fahrenheit: ");
		double tempInFahrenheit= Convert.ToDouble(Console.ReadLine());
		// Converting temperature in celsius to Fahrenheit
		double tempInCelsius= (tempInFahrenheit-32)* 5/9;
		Console.WriteLine("The "+tempInFahrenheit.ToString("F2")+" Fahrenheit is "+tempInCelsius.ToString("F2")+" Celsius");
	}
}