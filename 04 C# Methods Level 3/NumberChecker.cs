using System;
class NumberChecker
{
    // Method to find the count of digits in a number
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
    // Method to check if the number is a duck number
    public static bool IsDuckNumber(int number)
    {
		int d=0;
		int count=0;
        while(number!=0)
		{
			d=number%10;
			if(d == 0)
			{
				count++;
			}
			number=number/10;
		}
		if(count > 0 && d != 0)
		{
			return true;
		}else{
			return false;
		}
    }
    // Method to check if the number is an Armstrong number
    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = GetDigitsArray(number);
        int numDigits = digits.Length;
        int sum = 0;

        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, numDigits);
        }

        return sum == number;
    }
    // Method to find the largest and second largest elements in the digits array
    public static int[] FindLargestTwo(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return new int[] {largest, secondLargest};
    }
    // Method to find the smallest and second smallest elements in the digits array
    public static int[] FindSmallestTwo(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return new int[] {smallest, secondSmallest};
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = CountDigits(number);
        Console.WriteLine("Number of digits: "+count);
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: ");
		foreach(int v in digits)
		{
			Console.WriteLine(v+", ");
		}
        // Check if the number is a duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: "+isDuck);
        // Check if the number is an Armstrong number
        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine("Is Armstrong Number: "+isArmstrong);
        // Find the largest and second largest digits
        int[] largestAns = FindLargestTwo(digits);
        Console.WriteLine("Largest digit: "+largestAns[0]+", Second largest digit: "+largestAns[1]);
        // Find the smallest and second smallest digits
        int[] smallestAns = FindSmallestTwo(digits);
        Console.WriteLine("Smallest digit: "+smallestAns[0]+", Second smallest digit: "+smallestAns[1]);
    }
}