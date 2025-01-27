using System;
class SmallestAndLargest
{
	public static void Main(String[] args)
	{
		Console.Write("Enter first number : ");
		int num1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter second number : ");
		int num2=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter third number : ");
		int num3=Convert.ToInt32(Console.ReadLine());
		int[] arr=FindSmallestAndLargest(num1,num2, num3);
		Console.WriteLine("The smallest number is: "+arr[0]);
		Console.WriteLine("The largest number is: "+arr[2]);
	}
	public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
	{
		int[] arr=new int[3];
		arr[0]=number1;
		arr[1]=number2;
		arr[2]=number3;
		Array.Sort(arr);
		return arr;
	}
}