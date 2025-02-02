using System;
class MathematicalOperations
{
	public static void Main(String[] args)
	{
		// Taking input of two numbers from user
		Console.Write("Enter the first number: ");
		double n1=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the second number: ");
		double n2=Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter your choice as 'add', 'sub' ,'mult' or 'div': ");
		String choice=Convert.ToString(Console.ReadLine());
		choice=choice.ToLower();
		if( choice == "add")
		{
			Console.WriteLine("Sum of Addition of "+n1+" and "+n2+" is: "+Addition(n1, n2));
		}else if( choice == "sub")
		{
			Console.WriteLine("Result of Subtraction of "+n1+" and "+n2+" is: "+Subtraction(n1, n2));
		}else if(choice == "mult")
		{
			Console.WriteLine("Result of Multiplication of "+n1+" and "+n2+" is: "+Multiplication(n1, n2));
		}else if(choice == "div")
		{
			Console.WriteLine("Result of Division of "+n1+" and "+n2+" is: "+Division(n1, n2));
		}else{
			Console.WriteLine("Invalid Input.");
		}
	}
	// Method for Addition
	public static double Addition(double a,double b)
	{
		return a+b;
	}
	// Method for Subtraction
	public static double Subtraction(double a, double b)
	{
		if(a>b)
		{
			return a-b;
		}else{
			return b-a;
		}
	}
	// Method for Multiplication
	public static double Multiplication(double a, double b)
	{
		return a*b;
	}
	// Method for Division
	public static double Division(double a, double b)
	{
		if(a>b)
		{
			return a/b;
		}else{
			return b/a;
		}
	}
}