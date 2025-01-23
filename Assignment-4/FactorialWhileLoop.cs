using System;
class FactorialWhileLoop
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a number: ");
		int n=Convert.ToInt32(Console.ReadLine());
		if( n>=0){
			int factorial= 1;
			int temp = n;
			// Calculating factorial using while loop
			while(temp>1)
			{
				factorial *= temp;
				temp--;
			}
			Console.WriteLine("The factorial of "+n+" is "+factorial);
		}else{
			Console.WriteLine("Invalid input.");
		}
	}
}