using System;
class NaturalSum
{
	public static void Main(String[] args)
	{
		// Taking number as input from user
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		// Checking for Valid natural number
		if( num >=0)
		{
			int sum=num * (num+1)/2;
			Console.WriteLine("The sum of "+num+" natural numbers is "+sum);
		}else{
			Console.WriteLine("The number "+num+" is not a natural number");
		}
	}
}
		