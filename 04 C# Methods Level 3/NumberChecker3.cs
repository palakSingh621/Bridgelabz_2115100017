using System;
class NumberChecker3
{
    // Method to find the count of digits in the number
    public static int CountDigits(int number)
    {
       int length=0;
		while(number!=0)
		{
			number=number/10;
			length++;
		}
        return length;
    }
    // Method to store the digits of the number in a digits array
    public static int[] GetDigitsArray(int number)
    {
        int length=0;
		int dummy= number;
		while(dummy!=0)
		{
			dummy=dummy/10;
			length++;
		}
        int[] digits = new int[length];
        while(length!=0)
		{
			int d=number%10;
			digits[length-1]=d;
			length--;
			number=number/10;
		}
        return digits;
    }
    // Method to find the sum of the digits of a number
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }
    // Method to find the sum of the squares of the digits of a number
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach(int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }
    // Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }
    // Method to find the frequency of each digit in the number
    public static int[,] FindDigitFrequencies(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        // Initialize the frequency table with digit values
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i; // Digit
            frequency[i, 1] = 0; // Frequency
        }
        // Count the frequencies
        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }
        return frequency;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] digits = GetDigitsArray(number);
        int count = CountDigits(number);
        Console.WriteLine("Number of digits: "+count);
        int sumOfDigits = SumOfDigits(digits);
        Console.WriteLine("Sum of digits: "+sumOfDigits);
        int sumOfSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits: "+sumOfSquares);
        bool isHarshad = IsHarshadNumber(number, sumOfDigits);
        Console.WriteLine("Is Harshad Number: "+isHarshad);
        int[,] frequency = FindDigitFrequencies(digits);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine("Digit: "+frequency[i, 0]+", Frequency: "+frequency[i, 1]);
            }
        }
    }
}
