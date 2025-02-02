using System;
class Numbers
{
	public static void Main(String [] args){
		Console.Write("Enter a number: ");
		int input = Convert.ToInt32(Console.ReadLine());
		int copy = input;
		int sum = 0;
		int digit = 0;
		while( copy > 0 ){
			digit = copy % 10;
			sum += digit;
			copy /= 10;
		}
		if(input % sum ==0){
			Console.WriteLine(input + " is a Harshad Number");
		}
		else{
			Console.WriteLine(input + " is not a Harshad Number");
		}
	}
}
