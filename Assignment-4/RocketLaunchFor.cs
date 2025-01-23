using System;
class RocketLaunchFor
{
	public static void Main(String[] args)
	{
		// Taking the starting number for the countdown from the user
		Console.Write("Enter the starting number for the countdown: ");
		int counter= Convert.ToInt32(Console.ReadLine());
		//Countdown using for loop
		for(int i=counter;i>=1;i--){
			Console.WriteLine(i);
		}
		Console.WriteLine("Launch!");
	}
}