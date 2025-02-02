using System;
class Reverse
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string: ");
		String s=Convert.ToString(Console.ReadLine());
		String reverseString="";
		int length=s.Length;
		for(int i=length-1;i>=0;i--)
		{
			reverseString+=s[i];
		}
		Console.WriteLine("The reverseString is: "+reverseString);
	}
}