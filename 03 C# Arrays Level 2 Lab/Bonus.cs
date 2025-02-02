using System;
class Bonus
{
	public static void Main(String[] args)
	{
		double [] oldSalary = new double [10];
		double [] newSalary = new double [10];
		int [] services = new int [10];
		double [] bonus = new double[10];
		
		double totalOldSalary = 0;
		double totalNewSalary = 0;
		double totalBonus = 0;
		
		for(int i = 0;i < 10;i++)
		{
		// taking input in oldSalary
			Console.Write("Enter salary: ");
			double n = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter years of service: ");
			int service = Convert.ToInt32(Console.ReadLine());
			if(n < 0 || service < 0){
				Console.Write("Not valid");
				i--;
			}
			else{
				oldSalary[i] = n;
				services[i] = service;
			}
			totalOldSalary += oldSalary[i];
		}
		// Adding to newSalary and bonus
		for(int j=0;j<10;j++){
			if(services[j] > 5){
				bonus[j] = oldSalary[j] * 0.05;
			}
			else if(service[j] < 5){
				bonus[j] = oldSalary[j] * 0.02;
			}
			else{
				bonus[j] = 0;
			}
			newSalary[j] = oldSalary[j] + bonus[j];
			totalNewSalary += newSalary[j];
			totalBonus += bonus[j];
		}
		// Printing the totals
		Console.WriteLine("Total old salary "+totalOldSalary);
		Console.WriteLine("Total bonus "+totalBonus);
		Console.WriteLine("Total new salary "+totalNewSalary);
	}
}