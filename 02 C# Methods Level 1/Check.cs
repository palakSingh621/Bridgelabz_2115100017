using System;
class Check
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the number: ");
		int num=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Answer is: "+check(num));
	}
	public static int check(int n)
	{
		if(n< 0)
		{
			return -1;
		}else if(n>0){
			return 1;
		}else{
			return 0;
		}
	}
}
	