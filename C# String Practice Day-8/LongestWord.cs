using System;
class LongestWord
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the Sentence: ");
		String s= Convert.ToString(Console.ReadLine());
		// Removing extra spaces in the sentences
		s=s.Trim();
		// andding a one extra space at the end of the sentence
		s+=" ";
		int length=s.Length;
		int maxCount=0;
		int count=0;
		String spareWord="";
		String longestWord="";
		for(int i=0;i<length;i++)
		{
			// checking every word in the sentence breaking them at the spaces
			if(s[i]==' ')
			{
				if(count > maxCount)
				{
					maxCount=count;
					longestWord=spareWord;
				}
				count=0;
				spareWord="";
			}
			count++;
			spareWord+=s[i];
		}
		Console.WriteLine("The Longest Word is: "+longestWord);
	}
}