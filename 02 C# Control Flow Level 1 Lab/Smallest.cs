using System;
class Smallest
{
	public static void Main(String[] args)
	{
		//Taking Input numbers from user
		Console.Write("Enter the first number: ");
		int number1=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the second number: ");
		int number2=Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the Third number: ");
		int number3=Convert.ToInt32(Console.ReadLine());
		String isFirstSmallest;
		if(number1 < number2 && number1 < number3)
		{
			isFirstSmallest= "Yes";
		}else
		{
			isFirstSmallest="No";
		}
		Console.WriteLine("Is the first number the smallest? "+isFirstSmallest);
	}
}
		