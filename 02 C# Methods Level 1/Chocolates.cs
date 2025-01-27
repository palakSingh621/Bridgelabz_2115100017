using System;
class Chocolates
{
	public static void Main(String[] args)
	{
		//Taking input for the number of chocolates from the user
		Console.Write("Enter number of Chocolates: ");
		int numberOfChocolates= Convert.ToInt32(Console.ReadLine());
		//Taking input for the number of children from the user
		Console.Write("Enter number of Children: ");
		int numberOfChildren= Convert.ToInt32(Console.ReadLine());
		int[] arr= FindChocolates(numberOfChocolates, numberOfChildren);
		Console.WriteLine("The number of chocolates each child gets is "+arr[0]+" and the number of remianing chocolates is "+arr[1]);
	}
	public static int[] FindChocolates(int chocolate, int children) 
	{
		int[] arr= new int[2];
		//Calculating no.of chocolates each child get
		int chocolatesByEachChild= chocolate / children;
		arr[0]=chocolatesByEachChild;
		//Calculating the remaining Chocolates
		int remainingChocolates= chocolate % children;
		arr[1]=remainingChocolates;
		return arr;
	}
}
		
		