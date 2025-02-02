using System;
class SumOfNaturalNumbersForLoop
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the Natural Number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		//checking if the input number is natural number
		if(n >0){
			// Calculating sum using formula
			int sum=n*(n+1)/2;
			int loopSum=0;
			// Calculating sum using for loop
			for(int i=1;i<=n;i++)
			{
				loopSum += i;
			}
			// Comparing the sum
			if(sum==loopSum)
			{
				Console.WriteLine("Both Sum matched");
			}else{
				Console.WriteLine("Both Sums are different");
			}
		}else{
			Console.WriteLine("Not a Natural Number");
		}
	}
}
		