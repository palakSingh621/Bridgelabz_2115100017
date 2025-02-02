using System;
class Height
{
	public static void Main(String[] args)
	{
		double [] heights = new double [11];
		double sum = 0;
		// looping through 11 players and collecting heights to get the sum
		for(int i = 0; i < 11;i++){
			Console.Write("Enter height Player "+(i+1)+": ");
			double height = Convert.ToDouble(Console.ReadLine());
			heights[i] = height;
			sum += heights[i];
		}
		Console.WriteLine("The mean height is "+sum/11);
	}
}