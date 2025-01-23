using System;
class RocketLaunch
{
	public static void Main(String[] args)
	{
		// Taking the starting number for the countdown from the user
		Console.Write("Enter the starting number for the countdown: ");
		int counter= Convert.ToInt32(Console.ReadLine());
		//Countdown using while loop
		while(counter >=1){
			Console.WriteLine(counter);
			counter--;
		}
		Console.WriteLine("Launch!");
	}
}