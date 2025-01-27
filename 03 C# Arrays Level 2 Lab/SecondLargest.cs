using System;
class SecondLargest
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a number: ");
		int input = Convert.ToInt32(Console.ReadLine());
		int maxDigit = 10;
		int index = 0;
		int largest = 0;
		int secondLargest = 0;
		int[] arr = new int [maxDigit];
		while(input > 0)
		{
			int digit = input % 10;
			input /= 10;
			arr[index] = digit;
			index++;
			if(index == maxDigit)
			{ 
			// We set the max length of the numbers to 10
				break;
			}
		}
		for(int i = 0;i < index;i++)
		{
			if(arr[i] > largest){
				largest = arr[i];
			}
			else if(arr[i] > secondLargest){
				secondLargest = arr[i];
			}
		}
		Console.WriteLine("The largest digit is "+largest);
		Console.WriteLine("The second largest digit is "+secondLargest);
	}
}