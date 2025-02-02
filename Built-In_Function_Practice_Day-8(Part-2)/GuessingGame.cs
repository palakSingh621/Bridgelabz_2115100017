using System;
class GuessingGame
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Choose a number between 1-100 and keep that in mind");
		StartGame();
	}
	public static void StartGame()
	{
		int start=0;
		int end=100;
		bool guessedStatus=false;
		while(!guessedStatus)
		{	
			int guess=GenerateRandom(start, end);
			String feedback=UserFeedback(guess);
			// rearranging the value of guessing range according to user feedback
			if(feedback == "correct")
			{
				Console.WriteLine("The number is Guessed Successfully!");
				guessedStatus=true;
			}else if(feedback == "high")
			{
				end=guess-1;
			}else if(feedback == "low")
			{
				start=guess+1;
			}else{
				Console.WriteLine("Invalid feedback. Please enter a valid feedback.");
			}	
		}
	}
	//generating raandom number
	public static int GenerateRandom(int start, int end)
	{
		Random random=new Random();
		int guess=random.Next(start,end+1);
		return guess;
	}
	public static String UserFeedback(int guess)
	{
		// asking the user if the guessed number is correct or not
		Console.WriteLine("Is this your Guess number: "+guess+", if not then enter 'high', 'low' or 'correct' accordingly: ");
		String feedback= Convert.ToString(Console.ReadLine());
		feedback=feedback.ToLower();
		return feedback;
	}
}