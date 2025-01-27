using System;
class Largest
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
		String ans;
		//check for first largest
		if(number1 >= number2 && number1 >= number3)
		{
			ans= "Yes";
		}else
		{
			ans="No";
		}
		Console.WriteLine("Is the first number the largest? "+ans);
		//check for second largest
		if(number2 >= number1 && number2 >= number3)
		{
			ans= "Yes";
		}else
		{
			ans="No";
		}
		Console.WriteLine("Is the second number the largest? "+ans);
		//check for third largest
		if(number3 >= number1 && number3 >= number2)
		{
			ans= "Yes";
		}else
		{
			ans="No";
		}
		Console.WriteLine("Is the first number the largest? "+ans);
	}
}