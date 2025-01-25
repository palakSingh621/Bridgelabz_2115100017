using System;
class AgeHeight
{
	public static void Main(String[] args)
	{
		int [] ages = new int [3];
		double [] heights = new double [3];
		int maxAge = 0;
		double maxHeight = 0;
		for(int i=0;i<3;i++){
			Console.Write("Enter Age: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Height: ");
			double height = Convert.ToDouble(Console.ReadLine());
			ages[i] = age;
			heights[i] = height;
		}
		// looping through the array to find maxAge and MaxHeight
		for(int i=0;i<3;i++){
			if(maxAge < ages[i])
			{
				maxAge = ages[i];
			}
			if(maxHeight < heights[i])
			{
				maxHeight = heights[i];
			}
		}
		Console.WriteLine("The eldest one has the age "+maxAge);
		Console.WriteLine("The tallest one has the height "+maxHeight);
	}
}