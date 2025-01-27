using System;
class SumUntilZero
{
	public static void Main(String[] args)
	{
		double total=0.0;
		Console.WriteLine("Enter the number: ");
		double num=Convert.ToDouble(Console.ReadLine());
		// checking if user entered 0
		while(num!=0)
		{
			Console.WriteLine("Enter the number: ");
			num=Convert.ToDouble(Console.ReadLine());
			if(num==0){
				break;
			}
			total+=num;
		}
		Console.WriteLine("The total sum is: "+total);
	}
}