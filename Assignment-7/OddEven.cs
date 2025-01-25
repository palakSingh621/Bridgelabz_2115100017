using System;
class OddEven
{
	public static void Main(String[] args)
	{
		// Taking the input from user
		Console.Write("Enter the Number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//Checking for natural number
		if(number <=0)
		{
			Console.WriteLine("Error.");
			break;
		}
		// initializing even and odd arays with half of input number  as length
		int mid=(number+1)/2;
		int [] even = new int [mid];
		int [] odd = new int [mid];
		int evenCount=0;
		int oddCount=0;
		for(int i=1;i<= number;i++)
		{
			if( i % 2 == 0)
			{
				even[evenCount] = i;
				evenCount++;
			}else{
				odd[oddCount] = i;
				oddCount++;
			}
		}
		Console.WriteLine("Even Array: ");
		for(int j=0;j<evenCount;j++){
			Console.WriteLine(even[j]+"\n");
		}
		Console.WriteLine("Odd Array: ");
		for(int j=0;j<oddCount;j++){
			Console.WriteLine(odd[j]+"\n");
		}
	}
}