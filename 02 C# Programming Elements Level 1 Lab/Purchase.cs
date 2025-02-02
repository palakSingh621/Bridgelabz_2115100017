using System;
class Purchase
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the unit price of teh item (INR): ");
		double unitPrice = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the quality to be bought: ");
		int quantity= Convert.ToInt32(Console.ReadLine());
		double totalPrice = unitPrice * quantity;
		Console.WriteLine("The total purchase price is INR "+totalPrice.ToString("F2")+" if the quantity "+quantity+" and unit price in INR "+unitPrice.ToString("F2"));
	}
}