using System;
class Replace
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Enter the string: ");
		String str=Convert.ToString(Console.ReadLine());
		str=str.Trim();
		str+=" ";
		Console.WriteLine("Enter the word to replace: ");
		String replaceWord=Convert.ToString(Console.ReadLine());
		Console.WriteLine("Enter the Word to replace with: ");
		String replacingWord=Convert.ToString(Console.ReadLine());
		String result= ReplaceWord(str,replaceWord,replacingWord);
		Console.WriteLine("Modified String: "+result);
	}
	// Method to loop through the string finding and replacing the character
	public static String ReplaceWord(String s, String replace, String replaceWith)
	{
		String ans="";
		String word="";
		for(int i=0;i<s.Length;i++)
		{
			if(s[i] == ' ')
			{
				if(word == replace)
				{
					ans+=replaceWith;
					word="";
				}else{
					ans+=word;
					word="";
				}
				ans+=" ";
			}else{
				word+=s[i];
			}
		}
		return ans;
	}
}