using System;
class Power
{
	public static void Main(String [] args)
	{
		 Console.WriteLine("Enter base number:");
		 double numBase = Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("Enter power:");
		 double numPow = Convert.ToDouble(Console.ReadLine());
		 double ans= Math.Pow(numBase,numPow);
		 Console.WriteLine("The ans is :"+ ans);
	}
}