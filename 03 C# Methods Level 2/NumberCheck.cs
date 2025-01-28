using System;
class NumberCheck
{
	// Method to check if a number is Positive or Negative
	public static bool isPositive(int n)
	{
		if(n<0){
			return false;
		}else {
			return true;
		}
	}
	// Method to check if the number is even or Odd
	public static bool isEven(int n)
	{
		if(n%2==0)
		{
			return true;
		}else{
			return false;
		}
	}
	// Method to compare two numbers
	public static int compare(int n1, int n2)
	{
		if(n1>n2)
		{
			return 1;
		}else if(n1==n2){
			return -1;
		}else{
			return 0;
		}
	}
	public static void Main(String[] args)
	{
		int[] arr=new int[5];
		for(int i=0;i<5;i++)
		{
			Console.Write("Enter number "+(i+1)+": ");
			arr[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0;i<5;i++)
		{
			if(isPositive(arr[i]))
			{
				if(isEven(arr[i])){
					Console.WriteLine(arr[i]+" is a Positive and Even number");
				}else{
					Console.WriteLine(arr[i]+" is a Positive and Odd number");
				}
			}else{
				Console.WriteLine(arr[i]+" is a Negative number");
			}
		}
		int ans= compare(arr[0], arr[4]);
		if( ans==1)
		{
			Console.WriteLine(arr[0]+" is greater than "+arr[4]);
		}else if(ans == -1){
			Console.WriteLine(arr[0]+" is less than "+arr[4]);
		}else{
			Console.WriteLine(arr[0]+" and "+arr[4]+" are equal");
		}
	}
}