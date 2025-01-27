using System;
class Factor
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a number: ");
		int input = Convert.ToInt32(Console.ReadLine());
		int size = 0 ;
		//initializing factors array to store all the factor of the input number
		int [] factors = new int [input];
		for(int i=1; i<=input;i++){
			if(input % i == 0){
				factors[size] = i;
				size++;
			}
		}
		for(int j=0;j<size;j++){
			Console.WriteLine(factors[j]+"\n");
		}
	}
}