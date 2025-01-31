using System;
class Palindrome
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string or sequence: ");
		String input=Convert.ToString(Console.ReadLine());
		Display(input);
	}
	// Method to check the input for palindrome
	public static bool CheckPalindrome(String s)
	{
		int start=0;
		int end= s.Length-1;
		while(start <= end)
		{
			if(s[start]!= s[end])
			{
				return false;
			}
			start++;
			end--;
		}
		return true;
	}
	// Method to Display the result
	public static void Display(String s)
	{
		if(CheckPalindrome(s))
		{
			Console.WriteLine("Your input is Palindrome");
		}else{
			Console.WriteLine("Your input is not Palindrome");
		}
	}
}