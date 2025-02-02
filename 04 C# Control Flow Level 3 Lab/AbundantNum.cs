using System;
class AbundantNum
{
	public static void Main(String [] args)
	{
		Console.Write("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int copy = input;
		int divisorSum = 0;
		int i=1;
		while(i <= copy/2){
			if(copy % i == 0){
				divisorSum += i;
				i++;
			}
			else{
				i++;
			}
		}
		if( divisorSum > input ){
			Console.WriteLine(input+" is an abundant number");
		}
		else{
			Console.WriteLine(input+" is not an abundant number");
		}
	}
}
