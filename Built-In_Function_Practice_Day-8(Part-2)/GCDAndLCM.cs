using System;
class GCDAndLCM
{
	public static void Main(String[] args)
	{
		// Taking input of two numbers from user
		Console.Write("Enter the first number: ");
		int n1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the second number: ");
		int n2=Convert.ToInt32(Console.ReadLine());
		ResultDisplay(n1, n2);
	}
	// Method to Calculate Greatest Common Divisor
	public static int CalculateGCD(int n1, int n2)
	{
		int result=Math.Min(n1,n2);
		while(result>0)
		{
			if(n1%result==0 && n2%result==0)
			{
				return result;
			}else{	
				result--;
			}
		}
		return 1;
	}
	// Method to Calculate LCM of two numbers
	public static int CalculateLCM(int n1, int n2)
	{
		int prod=n1*n2;
		int gcd=CalculateGCD(n1, n2);
		int lcm=prod/gcd;
		return lcm;
	}
	// MEthod to print the output results
	public static void ResultDisplay(int n1, int n2)
	{
		Console.WriteLine("GCD: "+CalculateGCD(n1 , n2));
		Console.WriteLine("LCM: "+CalculateLCM(n1, n2));
	}
}