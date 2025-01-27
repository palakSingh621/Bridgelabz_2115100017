using System;
class TraingleAreaCalculator
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the base of triangle in centimeters: ");
		double baseCm = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the height of the triangle in centimeters: ");
		double heightCm = Convert.ToDouble(Console.ReadLine());
		double cmToInches = 2.54;
		double areaCm2= 0.5 * baseCm * heightCm;
		double baseInches = baseCm / cmToInches;
		double heightInches = heightCm /cmToInches;
		double areaIn2 = 0.5 * baseInches * heightInches;
		Console.WriteLine("the area of the triangle is "+areaCm2.ToString("F2")+" sqaure centimeters and "+areaIn2.ToString("F2")+" square inches.");
	}
}