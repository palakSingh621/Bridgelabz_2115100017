using System;

class ProfitLoss
{
	public static void Main(String[] args)
	{
		double costPrice = 129;
		double sellingPrice = 191;
		double profit = sellingPrice - costPrice;
		double profitPercentage = (profit / costPrice) * 100;
		Console.WriteLine("The Cost Price is INR "+costPrice+" and Selling Price is INR "+sellingPrice+"\nThe Profit is INR "+profit+" and the Profit Percentage is "+profitPercentage+"%");
	}
}