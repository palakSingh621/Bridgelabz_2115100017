using System;
class Occurences
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the Sentence: ");
		String s= Convert.ToString(Console.ReadLine());
		Console.Write("Enter the string to check the occurences of: ");
		String substr=Convert.ToString(Console.ReadLine());
		// Checking for empty strings
		if(s.Length==0 || substr.Length==0)
		{
			Console.WriteLine("Invalid Input");
		}else{
			int count = 0;
            for (int i =0;i<=s.Length-substr.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < substr.Length; j++)
                {
                    if (s[i + j] != substr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if(match)
                {
                    count++;
                }
            }
			Console.WriteLine("Number of Occurences of Substring in the sentence: "+count);
		}
	}
}
			