using System;
class Multidimensional
{
	public static void Main(String[] args)
	{
		Console.Write("Enter the number of rows: ");
		int rows = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number of columns: ");
		int columns = Convert.ToInt32(Console.ReadLine());
		int [,] twoD = new int [rows , columns];
		int [] oneD = new int [rows * columns];
		
		for(int i = 0;i < rows;i++){ 
		// Storing the values in 2D array 
			for(int j = 0;j < columns;j++){
				Console.WriteLine("Enter the element");
				int input = Convert.ToInt32(Console.ReadLine());
				twoD [i,j] = input;
			}
		}
		for(int k = 0;k < rows * columns;k++){ 
		// Converting 2D to 1D Array
			int i = k/columns;
			int j = k%columns;
			oneD[k] = twoD[i,j];
		}
		for(int l=0;l<rows * columns;l++){ 
		//printing the 1D Array
			Console.WriteLine(oneD[l]+" ");
		}
	}
}
