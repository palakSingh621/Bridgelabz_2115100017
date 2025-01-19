using System;
class Interest
{
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter principal Amount:");
		double principal =Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter rate percent:");
		double rate = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter Time:");
		double time = Convert.ToDouble(Console.ReadLine());
		double interest= (principal * rate * time)/100;
		Console.WriteLine("The simple interest is :"+ interest);
	}
}