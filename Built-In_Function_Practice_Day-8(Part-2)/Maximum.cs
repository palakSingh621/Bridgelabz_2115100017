using System;
class Maximum
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the first number: ");
		int n1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the second number: ");
		int n2=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the third number: ");
		int n3=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The maximum number is: "+FindMaximum(n1,n2,n3));
	}
	// Method to calculate the Maximum among the inputted integer
	public static int FindMaximum(int n1, int n2, int n3)
	{
		int max=Math.Max(n1, Math.Max(n2,n3));
		return max;
	}
}