using System;
class VowelsConsonants
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the String: ");
		String s=Convert.ToString(Console.ReadLine());
		int vowels=0;
		int consonants=0;
		int length=s.Length;
		for(int i=0;i<length;i++)
		{
			if(s[i]=='a' || s[i]=='e' || s[i]=='o' || s[i]=='u')
			{
				vowels++;
			}else{
				consonants++;
			}
		}
		Console.WriteLine("No. of Vowels in the string are: "+vowels);
		Console.WriteLine("No. of Consonants in the string are: "+consonants);
	}
}