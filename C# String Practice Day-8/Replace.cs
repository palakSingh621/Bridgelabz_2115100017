using System;
class Replace
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter the string: ");
		String str=Convert.ToString(Console.ReadLine());
		Console.WriteLine("Enter the charater to replace: ");
		char replaceCharacter=Convert.ToChar(Console.ReadLine());
		Console.WriteLine("Enter the character to replace with: ");
		char replacingCharacter=Convert.ToChar(Console.ReadLine());
		String result= ReplaceCharacter(str,replaceCharacter,replacingCharacter);
		Console.WriteLine("Modified String: "+result);
	}
	// Method to loop through the string finding and replacing the character
	public static String ReplaceCharacter(String s, char replace, char replaceWith)
	{
		String ans="";
		for(int i=0;i<s.Length;i++)
		{
			if(s[i] == replace)
			{
				ans+=replaceWith;
			}else{
				ans+=s[i];
			}
		}
		return ans;
	}
}