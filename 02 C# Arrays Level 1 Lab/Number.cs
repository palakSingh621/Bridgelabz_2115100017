using System;
class Number
{
	public static void Main(String[] args)
	{
		// Initializing array
		int [] nums=new int[5];
		for(int i=0 ;i <5;i++)
		{
		Console.Write("Enter a number "+(i+1)" :");
		int n = Convert.ToInt32(Console.ReadLine());
		nums[i] = n;
		}
		// looping through the array to check for positive, negative, even and odd number
		for(int j=0;j<5;j++){
			if(nums[j] > 0){
				if(nums[j] % 2 == 0){
					Console.WriteLine("The number "+nums[j]+" is positive and even.");
				}
				else{
					Console.WriteLine("The number "+nums[j]+" is positive and odd.");
				}
			}
			else if(nums[j] < 0){
				Console.WriteLine("The number "+nums[j]+" is negative");
			}
			else{
				Console.WriteLine("The number "+nums[j]+" is zero");
			}
		}
		if(nums[0] > nums[4])
		{
			Console.WriteLine("The first number is greater than the last number.");
		}
		else if(nums[0] < nums[4])
		{
			Console.WriteLine("The first number is lesser than the last number.");
		}
		else
		{
			Console.WriteLine("The first and the last number are equal.");
		}
	}
}
