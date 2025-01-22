using System;
class City
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the name: ");
		string name=Convert.ToString(Console.ReadLine());
		Console.Write("Enter the the From City: ");
		string fromCity=Convert.ToString(Console.ReadLine());
		Console.Write("Enter the via City: ");
		string viaCity=Convert.ToString(Console.ReadLine());
		Console.Write("Enter the Final City: ");
		string toCity=Convert.ToString(Console.ReadLine());
		
		Console.Write("Enter the distance between the from and the via City in miles: ");
		double formToVia=Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter the distance between the via City and the final City in miles: ");
		double viaToFinalCity=Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter the time taken for the journey: ");
		double timeTaken=Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("The result of the trip are: Travel journey of "+name+" The journey is starting form the city "+fromCity+" and going through the city of "+viaCity+" and finally ending at the city of "+toCity+". The total distance of the journey is "+formToVia+viaToFinalCity+" miles and the total time to complete this journey is "+timeTaken+" Hours");
	}
}
		