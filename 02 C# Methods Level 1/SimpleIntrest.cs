using System;
class SimpleIntrest
{
	public static void Main(String[] args)
	{
		//Taking Principle, Rate ad Time as user input
		Console.Write("Principal: ");
		double principal=Convert.ToDouble(Console.ReadLine());
		Console.Write("Rate: ");
		double rate=Convert.ToDouble(Console.ReadLine());
		Console.Write("Time: ");
		double time=Convert.ToDouble(Console.ReadLine());
		double simpleInterest=Intrest(principal,rate,time);
		Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principle "+principal+", Rate of interest "+rate+" and Time "+time);
	}
	public static double Intrest(double principal, double rate, double time)
	{
		//Calculating Simple Intrest
		double simpleInterest= (principal * rate * time)/100;
		return simpleInterest;
	}
}