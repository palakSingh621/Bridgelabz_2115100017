using System;
class Trigonometry
{
	public static void Main(String[] args)
	{
		// taking input as an Angle form the user
		Console.Write("Enter the Angle: ");
		double angle=Convert.ToDouble(Console.ReadLine());
		
		double[] results= CalculateTrigonometricFunctions(angle);
		
		Console.WriteLine("Sine: "+results[0]);
		Console.WriteLine("Cosine: "+results[1]);
		Console.WriteLine("Tangent: "+results[2]);
	}
	public static double[] CalculateTrigonometricFunctions(double angle)
	{
		// Converting the angle to Radians
		double angleInRadians=angle*(Math.PI/180);
		// Calculating sine, cosine and tangent
		double sine= Math.Sin(angleInRadians);
		double cosine= Math.Cos(angleInRadians);
		double tangent= Math.Tan(angleInRadians);
		
		return new double[] { sine, cosine, tangent };
	}
}