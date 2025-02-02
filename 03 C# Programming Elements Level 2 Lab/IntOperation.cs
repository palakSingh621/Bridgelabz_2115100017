using System;
class IntOperation
{
	public static void Main(String[] args)
	{
		//taking value of 'a' form user
		Console.Write("Enter first value: ");
		int a=Convert.ToInt32(Console.ReadLine());
		//taking value of 'b' form user
		Console.Write("Enter second value: ");
		int b=Convert.ToInt32(Console.ReadLine());
		//taking value of 'c' form user
		Console.Write("Enter third value: ");
		int c=Convert.ToInt32(Console.ReadLine());
		
		int v1=a+b*c;
		int v2=a*b+c;
		int v3= c+a/b;
		int v4 = a%b+c;
		
		Console.WriteLine("The result of Int Operations are "+v1+", "+v2+", "+v3+" and "+v4);
	}
}

