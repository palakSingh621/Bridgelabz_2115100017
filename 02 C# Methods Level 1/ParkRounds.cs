using System;
class ParkRounds
{
	public static void Main(String[] args)
	{
		//Taking input of side 1 of triangle
		Console.Write("Enter side1 of triangular park: ");
		double side1=Convert.ToDouble(Console.ReadLine());
		//Taking input of side 2 of triangle
		Console.Write("Enter side2 of triangular park: ");
		double side2=Convert.ToDouble(Console.ReadLine());
		//Taking input of side 3 of triangle
		Console.Write("Enter the side3 of triangular park: ");
		double side3=Convert.ToDouble(Console.ReadLine());
		double rounds=parkrounds(side1, side2, side3);
		Console.WriteLine("The total number of rounds the athlete will run is "+rounds+" to complete 5km");
	}
	public static double parkrounds(double side1, double side2, double side3)
	{
		//Calculating triangular park Perimeter
		double perimeter= side1+side2+side3;
		//Calculating no.of rounds to complete a 5km run
		double rounds=perimeter/5;
		return rounds;
	}
}