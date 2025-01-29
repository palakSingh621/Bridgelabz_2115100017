using System;
class RemoveDuplicates
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string: ");
		String s= Convert.ToString(Console.ReadLine());
		int length=s.Length;
		String resultString="";
		// iterating through the string to skip duplicates
		for(int i=0;i<length-1;i++)
		{
			while(i+1<length && s[i]==s[i+1])
			{
				i++;
			}
			resultString+=s[i];
		}
		Console.WriteLine("The Non-Duplicate String: "+resultString);
	}
}