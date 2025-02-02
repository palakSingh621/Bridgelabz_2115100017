using System;
class HeightConverter
{
	public static void Main(String[] args)
	{
		Console.Write("Enter your height in centimeters: ");
		double heightCm = Convert.ToDouble(Console.ReadLine());
		double cmToInches= 2.54;
		int inchesPerFoot=12;
		double totalInches = heightCm /cmToInches;
		int feet =(int)(totalInches/inchesPerFoot);
		double inches= totalInches % inchesPerFoot;
		Console.WriteLine("Your height in cm is "+heightCm+" while in feet is "+feet+" and inches is "+inches.ToString("F2"));
	}
}