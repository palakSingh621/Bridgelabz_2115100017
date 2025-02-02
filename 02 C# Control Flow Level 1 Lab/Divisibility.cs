using System;
class Divisibility
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		// checking divisiblity by 5
		String ans;
		if(number%5==0)
		{
			ans="Yes";
		}else
		{
			ans="No";
		}
		Console.WriteLine("Is the number "+number+" divisible by 5? "+ans);
	}
}