using System;
class FactorialForLoop
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a number: ");
		int n=Convert.ToInt32(Console.ReadLine());
		if( n>=0){
			int factorial= 1;
			// Calculating factorial using for loop
			for(int i=1;i<=n;i++)
			{
				factorial *= i;
			}
			Console.WriteLine("The factorial of "+n+" is "+factorial);
		}else{
			Console.WriteLine("Invalid input.");
		}
	}
}