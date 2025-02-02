using System;
class NumberChecker6
{
	// Method to find factors os a number
	public static int[] FindFactor(int num)
	{
		int count=0;
		for(int i=1;i<=num;i++){
			if(num%i==0){
				count++;
			}
		}
		int[] ans=new int[count];
		int index=0;
		for(int i=1;i<=num;i++){
			if(num%i == 0){
				ans[index]=i;
				index++;
			}
		}
		return ans;
	}
	// Method to find the greatest factor of a number 
	public static int GreatestFactor(int[] factors)
	{
		int length=factors.Length;
		return factors[length-1];
	}
	// Method to get the sum of factors from factors array
	public static int FactorSum(int[] factors)
	{
		int sum=0;
		foreach(int v in factors)
		{
			sum+=v;
		}
		return sum;
	}
	// Method to get the product of factors
	public static int FactorProduct(int[] factors)
	{
		int prod=1;
		foreach(int v in factors)
		{
			prod*=v;
		}
		return prod;
	}
	// Method to get the product of cube of the factors
	public static double FactorCubeProduct(int[] factors)
	{
		double prod=1;
		foreach(int v in factors)
		{
			prod*=Math.Pow(v,3);
		}
		return prod;
	}
	// Method to check Perfect number
	public static bool IsPerfect(int num, int[] factors)
	{
		int sum= FactorSum(factors);
		if(num == sum){
			return true;
		}else{
			return false;
		}
	}
	// Method to check Abundant number
	public static bool IsAbundant(int num, int[] factors)
	{
		int sum= FactorSum(factors);
		if(num < sum){
			return true;
		}else{
			return false;
		}
	}
	// Method to check Deficient number
	public static bool IsDeficient(int num, int[] factors)
	{
		int sum= FactorSum(factors);
		if(num > sum){
			return true;
		}else{
			return false;
		}
	}
	// Method to check Strong Number
	public static bool IsStrong(int num)
	{
		int dummy=num;
		int sum=0;
		while(dummy!=0)
		{
			int d= dummy%10;
			int prod=1;
			for(int i=1;i<=d;i++)
			{
				prod*=i;
			}
			sum+=prod;
			dummy=dummy/10;
		}
		if(sum==num)
		{
			return true;
		}else{
			return false;
		}
	}
	public static void Main(String[] args)
	{
		Console.Write("Enter the number: ");
		int num= Convert.ToInt32(Console.ReadLine());
		// getting the factor Array
		int[] factors=FindFactor(num);
		Console.WriteLine("Factor Array: ");
		foreach(int v in factors)
		{
			Console.Write(v+", ");
		}
		Console.WriteLine("The Greatest Factor is: "+GreatestFactor(factors));
		Console.WriteLine("The Sum of Factors is: "+FactorSum(factors));
		Console.WriteLine("The Product of Factors is: "+FactorProduct(factors));
		Console.WriteLine("The Product of Cube of the Factors is: "+FactorCubeProduct(factors));
		if(IsPerfect(num,factors))
		{
			Console.WriteLine("The number is Perfect.");
		}else{
			Console.WriteLine("The number is not Perfect.");
		}
		if(IsAbundant(num,factors))
		{
			Console.WriteLine("The number is Abundant.");
		}else{
			Console.WriteLine("The number is not Abundant.");
		}
		if(IsStrong(num))
		{
			Console.WriteLine("The number is Strong.");
		}else{
			Console.WriteLine("The number is not Strong.");
		}
		if(IsDeficient(num,factors))
		{
			Console.WriteLine("The number is Deficient.");
		}else{
			Console.WriteLine("The number is not Deficient.");
		}
	}
}
	