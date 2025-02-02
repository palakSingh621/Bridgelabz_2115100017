 using System;
class Temperature
 {
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter temp in celcius:");
		double tempCelsius = Convert.ToDouble(Console.ReadLine());
		double farh= (tempCelsius*1.8)+32;
		Console.WriteLine("The temperature in Fahrenheit:"+ farh);
	}
 }