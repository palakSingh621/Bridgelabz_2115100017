using System;
class Spring
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the month number: ");
		int month= Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the day number: ");
		int day= Convert.ToInt32(Console.ReadLine());
		// Checking for the Spring season
		if((month==3 && day >=20 && day<=31)||(month==4 && day >=1 && day<=30)||(month==5 && day >=1 && day<=31)||(month==6 && day >=1 && day<=20)){
			Console.WriteLine("It's a Spring Season.");
		}else{
			Console.WriteLine("Not a Spring Season.");
		}
	}
}
		