using System;
class FizzBuzz
{
	public static void Main(String[] args)
	{
		// Taking number as input from the user
		Console.Write("Enter a number: ");
		int length = Convert.ToInt32(Console.ReadLine());
		string [] arr = new string [length];
		//looping through the array
		for(int i=0;i<length;i++){
			// Storing FizzBuzz for index multiples of 3 and 5
			if(i % 3 ==0 && i % 5 ==0){
				arr[i] = "FizzBuzz";
			}
			// Storing Buzz for index multiples of 5
			else if(i % 5 ==0){
				arr[i] = "Buzz";
			}
			// Storing Fizz for index multiples of 3
			else if( i % 3 ==0){
				arr[i] = "Fizz";
			}
			else{
				arr[i] = Convert.ToString(i);
			}
		}
		for(int j =0;j < length;j++)
		{
			Console.WriteLine("Position "+(j+1)+" ="+arr[j]+", ");
		}
	}
}
