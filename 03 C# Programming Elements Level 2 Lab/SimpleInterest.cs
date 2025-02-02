using System;
class SimpleInterest
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
		//Calculating Simple Interest
		double simpleInterest= (principal * rate * time)/100;
		Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principle "+principal+", Rate of interest "+rate+" and Time "+time);
	}
}
		