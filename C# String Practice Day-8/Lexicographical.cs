using System;
class Lexicographical
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the first string: ");
		String str1= Convert.ToString(Console.ReadLine());
		Console.Write("Enter the second string: ");
		String str2= Convert.ToString(Console.ReadLine());
		int ans=CompareLexicographically(str1, str2);
		if(ans < 0)
		{
			Console.WriteLine(str1+" comes before "+str2+" in lexicographical order");
		}else if(ans > 0)
		{
			Console.WriteLine(str1+" comes after "+str2+" in lexicographical order");
		}else{
			Console.WriteLine(str1+" and "+str2+" are in same lexicographical order");
		}	
	}
	// Method to Check Lexicographical order of both strings
	public static int CompareLexicographically(String str1, String str2)
	{
		int length=Math.Min(str1.Length, str2.Length);
		for(int i=0;i<length;i++)
		{
			if(str1[i]<str2[i])
			{
				return -1;
			}else if(str1[i]>str2[i])
			{
				return 1;
			}
		}
		if(str1.Length < str2.Length)
		{
			return -1;
		}else if(str1.Length > str2.Length)
		{
			return 1;
		}else{
			return 0;
		}
	}
}
				