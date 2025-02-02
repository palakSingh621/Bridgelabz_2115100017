using System;
class Anagram
{
	public static void Main(String[] args)
	{
		Console.Write("Enter first String: ");
		String s1=Convert.ToString(Console.ReadLine());
		Console.Write("Enter second String: ");
		String s2=Convert.ToString(Console.ReadLine());
		if(CheckAnagram(s1,s2))
		{
			Console.WriteLine("Strings are Anagram");
		}else{
			Console.WriteLine("Strings are not Anagram");
		}
	}
	// Method to check the Strings as anagram
	public static bool CheckAnagram(String s1, String s2)
	{
		if(s1.Length != s2.Length)
		{
			return false;
		}
		// Converting strings to Character Array
		char[] c1=s1.ToLower().ToCharArray();
		char[] c2=s2.ToLower().ToCharArray();
		// Sorting the Character Arrays
		Array.Sort(c1);
		Array.Sort(c2);
		s1=new String(c1);
		s2=new String(c2);
		return s1==s2;
	}
}