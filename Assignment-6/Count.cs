using System;
class Count
{
	public static void Main(String [] args)
	{
		Console.WriteLine("Enter a number: ");
		int input = Convert.ToInt32(Console.ReadLine());
		int dummy = input;
		int digitCount = 0;
		while(input > 0){
			input /= 10;
			digitCount++;
		}
		Console.WriteLine("The number of digits in "+dummy+" is "+ digitCount);
	}
}

