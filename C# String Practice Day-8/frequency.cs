using System;
class Frequency
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string: ");
		String str= Convert.ToString(Console.ReadLine());
		int length=str.Length;
		char frequentCharacher = ' ';
		int maxCount=0;
		// looping through every character in the string
		for(int i=0;i<length;i++)
		{
			int count=0;
			// looping from the i'th character to the rest string and counting the frequency of the i'th character
			for(int j=i;j<length;j++)
			{
				if(str[i]==str[j])
				{
					count++;
				}
			}
			if(count > maxCount)
			{
				maxCount=count;
				frequentCharacher=str[i];
			}
		}
		Console.WriteLine("The most Frequent Character is: "+frequentCharacher);
	}
}
				