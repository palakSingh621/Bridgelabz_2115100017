using System;
class SumUntilZeroOrNegative
{
	public static void Main(String[] args)
	{
		double total=0.0;
		// creating infinite while loop
		while(true)
		{
			Console.WriteLine("Enter the number: ");
			double num=Convert.ToDouble(Console.ReadLine());
			if(num <= 0){
				break;
			}
			total+=num;
		}
		Console.WriteLine("The total sum is: "+total);
	}
}