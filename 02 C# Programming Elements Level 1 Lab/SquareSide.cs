using System;
class SquareSide
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the perimeter of the square: ");
		double perimeter = Convert.ToDouble(Console.ReadLine());
		double side = perimeter/4;
		Console.WriteLine("the Length of the side is "+side.ToString("F2")+" whose perimeter is "+perimeter.ToString("F2"));
	}
}