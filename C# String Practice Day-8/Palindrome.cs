using System;
class Palindrome
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string: ");
		string s= Convert.ToString(Console.ReadLine());
		int length= s.Length;
		int start=0;
		int end=length-1;
		while(start<=end)
		{
			if(s[start] == s[end])
			{
				start++;
				end--;
			}else{
				Console.WriteLine(" String is not Plaindrome");
				break;
			}
		}
		if(start >= end)
		{
			Console.WriteLine("String is Plaindrome");
		}
	}
}