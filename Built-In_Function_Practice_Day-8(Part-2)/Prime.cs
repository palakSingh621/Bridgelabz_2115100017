using System;
class Prime
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the number: ");
		int num =Convert.ToInt32(Console.ReadLine());
		if(IsPrime(num))
		{
			Console.WriteLine(num+" is a Prime Number");
		}else{
			Console.WriteLine(num+" is not a Prime Number");
		}
	}
	// Method to check if the number is prime
	public static bool IsPrime(int n)
	{
		int count=0;
		for(int i=2;i<n;i++)
		{
			if(n%i==0)
				count++;
		}
		if(count>0)
		{
			return false;
		}else{
			return true;
		}
	}
}