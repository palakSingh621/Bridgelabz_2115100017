using System;
class TableFrom6to9
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a number: ");
		int input = Convert.ToInt32(Console.ReadLine());
		int [] table= new int [4];
		// looping from 6-9 to get the multiple of input number.
		for(int i=6;i <=9 ;i++){
			table[i-6] = input * i;
			Console.WriteLine(input +" * "+i+" = "+table[i-6]);
		}
	}
}