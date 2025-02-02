using System;
class Number
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the number: ");
		int num= Convert.ToInt32(Console.ReadLine());
		// Checking the number if positive, negative or zero
		if(num >0){
			Console.WriteLine("The number is positive.");
		}else if(num <0){
			Console.WriteLine("The number is negative.");
		}else{
			Console.WriteLine("The number is zero.");
		}
	}
}