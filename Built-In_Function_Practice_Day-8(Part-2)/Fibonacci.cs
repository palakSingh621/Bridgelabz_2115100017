using System;
class Fibonacci
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the series number: ");
		int limit=Convert.ToInt32(Console.ReadLine());
		CreatingSeries(limit);
	}
	// Method to Calculating and printing the fibonacci Series
	public static void CreatingSeries(int n)
	{
		int firstNum=0;
		int secondNum=1;
		Console.Write("Fibonacci Series: ");
		while(secondNum<=n)
		{
			Console.Write(secondNum+", ");
			int sum=firstNum+secondNum;
			firstNum=secondNum;
			secondNum=sum;
		}
	}
}