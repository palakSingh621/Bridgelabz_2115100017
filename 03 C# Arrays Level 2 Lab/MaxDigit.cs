using System;
class MaxDigit
{
	public static void Main(String[] args)
	{
		Console.Write("Enter a number: ");
		int input = Convert.ToInt64(Console.ReadLine());
		int maxDigit = 10;
		int index = 0;
		int largest = 0;
		int secondLargest = 0;
		int [] arr = new int [maxDigit];
		while(input > 0)
		{
			int digit = (int)input % 10;
			input /= 10;
			arr[index] = digit;
			index++;
			// We set the max length of the numbers to 10
			if(index == maxDigit)
			{ 
				maxDigit += 10;
				int [] tempArr = new int [maxDigit];
				for(int j = 0;j < index;j++){
					tempArr[j] = arr[j];
				}
				arr = tempArr;
			}
		}
		for(int i = 0;i < index;i++){
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
