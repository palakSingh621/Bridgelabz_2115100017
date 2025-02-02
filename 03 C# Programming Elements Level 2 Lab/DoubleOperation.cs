using System;
class DoubleOperation
{
	public static void Main(String[] args)
	{
		//taking value of 'a' form user
		Console.Write("Enter first value: ");
		double a=Convert.ToDouble(Console.ReadLine());
		//taking value of 'b' form user
		Console.Write("Enter second value: ");
		double b=Convert.ToDouble(Console.ReadLine());
		//taking value of 'c' form user
		Console.Write("Enter third value: ");
		double c=Convert.ToDouble(Console.ReadLine());
		
		double v1=a+b*c;
		double v2=a*b+c;
		double v3= c+a/b;
		double v4 = a%b+c;
		
		Console.WriteLine("The result of Double Operations are "+v1.ToString("F2")+", "+v2.ToString("F2")+", "+v3.ToString("F2")+" and "+v4.ToString("F2"));
	}
}