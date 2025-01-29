using System;
class ToggleCase
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the string: ");
		String str=Convert.ToString(Console.ReadLine());
		int length= str.Length;
		String resultString="";
		for(int i=0;i<length;i++)
		{	
			//Checking if the character is UpperCase Condition to chenge to lowerCase and vice-versa
			if(char.IsUpper(str[i]))
			{
				resultString+=char.ToLower(str[i]);
			}else{
				resultString+=char.ToUpper(str[i]);
			}
		}
		Console.WriteLine("The Toggled String is: "+resultString);
	}
}