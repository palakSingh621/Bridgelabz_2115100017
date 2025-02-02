using System;
class ValidVote
{
	public static void Main(String[] args)
	{
		// Taking input age from user
		Console.Write("Enter the person's age: ");
		int age=Convert.ToInt32(Console.ReadLine());
		if(age >=0)
		{
			//Checking age validation to vote
			if(age >=18)
			{
				Console.WriteLine("The person's age is "+age+" and can vote.");
			}else{
				Console.WriteLine("The person's age is "+age+" and cannot vote.");
			}
		}else{
			Console.WriteLine("Invalid input. Please enter a valid integer for the age.");
		}
	}
}