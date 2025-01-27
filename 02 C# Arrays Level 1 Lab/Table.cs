using System;
class Table
{
	public static void Main(String[] args)
	{
		// Taking the number to input from user
		Console.Write("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		int [] table = new int [10];
		// looping from 1-10 and getting multiples of the number table.
		for(int i=1;i<=10;i++){
			table[i-1] = i * n; 
		}
		for(int j=0;j<10;j++){
			Console.WriteLine(n+" * "+(j+1)+" = "+table[j]);
		}
	}
}