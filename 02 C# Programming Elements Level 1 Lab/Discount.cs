using System;

class Discount
{
	public static void Main(String[] args)
	{
		double fee = 125000;
		double discountPercent = 10;
		double discountAmount = (fee * discountPercent) / 100;
		double discountFee = fee - discountAmount;
		Console.WriteLine("The discount amount is INR "+discountAmount+" and final discounted fee is INR "+discountFee);
	}
}