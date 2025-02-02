using System;
class Factorial
{
	public static void Main(String[] args)
	{
		// Taking input from the user
		Console.Write("Enter the number: ");
		int num=Convert.ToInt32(Console.ReadLine());
		Output(num);
	}
	// method to calculate Factorial recursively
	public static int CalculateFactorial(int n,int i, int prod)
	{
		int ans=prod;
		if(i<=n)
		{
			prod*=i;
			ans=CalculateFactorial(n,i+1,prod);
		}
		return ans;
	}
	// Method to display the output
	public static void Output(int n)
	{
		int ans=1;
		Console.WriteLine("The factorial is :"+CalculateFactorial(n,1,ans));
	}
}