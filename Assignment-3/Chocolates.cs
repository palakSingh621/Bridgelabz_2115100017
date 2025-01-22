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
		//Calculating no.of chocolates each child get
		int chocolatesByEachChild= numberOfChocolates / numberOfChildren;
		//Calculating the remaining Chocolates
		int remainingChocolates= numberOfChocolates % numberOfChildren;
		Console.WriteLine("The number of chocolates each child gets is "+chocolatesByEachChild+" and the number of remianing chocolates is "+remainingChocolates);
	}
}
		
		