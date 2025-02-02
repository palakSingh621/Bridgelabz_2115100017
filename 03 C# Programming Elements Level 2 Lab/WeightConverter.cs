using System;
class WeightConverter
{
	public static void Main(String[] args)
	{
		//Taking input as weight in pounds
		Console.Write("Enter Weight in Pounds: ");
		double weightInPounds=Convert.ToDouble(Console.ReadLine());
		//Converting weight in pounds to weight in kilograms
		double weightInKg = weightInPounds*2.2;
		Console.WriteLine("The weight of the person in pounds is "+weightInPounds+" and in kg is "+weightInKg);
	}
}
		