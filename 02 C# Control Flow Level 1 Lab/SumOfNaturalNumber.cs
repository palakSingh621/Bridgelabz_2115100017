using System;
class SumOfNaturalNumbers
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
			int counter =1;
			// Calculating sum using while loop
			while(counter <=n)
			{
				loopSum += counter;
				counter++;
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
		