using System;
class TotalIncome
{
	public static void Main(String[] args)
	{
		//Taking user salary input
		Console.Write("Enter the Salary: ");
		double salary=Convert.ToDouble(Console.ReadLine());
		
		//Taking user Bonus input
		Console.Write("Enter the Bonus: ");
		double bonus= Convert.ToDouble(Console.ReadLine());
		
		//Calculating total income by adding salary and bonus
		double income=salary+bonus;
		Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+income);
	}
}
		