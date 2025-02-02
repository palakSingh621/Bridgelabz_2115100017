using System;
class QuotientRemainder
{
	public static void Main(String[] args)
	{
		Console.Write("Enter first number : ");
		int num1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter second number : ");
		int num2=Convert.ToInt32(Console.ReadLine());
		int[] arr=FindRemainderAndQuotient(num1,num2);
		Console.WriteLine("The Quotient is: "+arr[0]);
		Console.WriteLine("The Remainder is: "+arr[1]);
	}
	public static int[] FindRemainderAndQuotient(int number, int divisor) 
	{
		// Calculating Quotient and remainder and storing them in an array
		int[] arr=new int[2];
		int quotient=number/divisor;
		arr[0]=quotient;
		int remainder= number%divisor;
		arr[1]=remainder;
		return arr;
	}
}