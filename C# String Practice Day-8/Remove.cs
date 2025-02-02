using System;
class Remove
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string: ");
		String str= Convert.ToString(Console.ReadLine());
		Console.Write("Enter the character to remove from the string: ");
		char ch= Convert.ToChar(Console.ReadLine());
		String resultString="";
		// iterating through the string to find the character to remove
		for(int i=0;i<str.Length;i++)
		{
			if(str[i]!=ch)
			{
				resultString+=str[i];
			}
		}
		Console.WriteLine("Modified string: "+resultString);
	}
}