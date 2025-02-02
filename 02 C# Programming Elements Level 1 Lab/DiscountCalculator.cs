using System;
class DiscountCalculator
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the student fee (INR): ");
		double fee= Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the discount percentage: ");
		double discountPercent= Convert.ToDouble(Console.ReadLine());
		double discountAmount =(fee * discountPercent)/100;
		double discountFee = fee - discountAmount;
		Console.WriteLine("The discount amount is INR "+discountAmount.TzoString("F2")+" and final discounted fee is INR "+discountFee.ToString("F2"));
	}
}