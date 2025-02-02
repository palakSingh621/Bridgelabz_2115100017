using System;
class NumberChecker4
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
    // Method to reverse the digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }
    // Method to compare two arrays and check if they are equal
    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length) return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }
    // Method to check if a number is a palindrome using the digits array
    public static bool IsPalindrome(int number)
    {
        int[] digits = GetDigitsArray(number);
        int[] reversedDigits = ReverseArray(digits);

        return CompareArrays(digits, reversedDigits);
    }
    // Method to check if a number is a duck number using the digits array
    public static bool IsDuckNumber(int number)
    {
        int[] digits = GetDigitsArray(number);

        foreach (int digit in digits)
        {
            if (digit == 0)
            {
                return true; 
			}
        }

        return false;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int digitCount = CountDigits(number);
        int[] digits = GetDigitsArray(number);
        Console.WriteLine("Digits: ");
		foreach(int d in digits)
		{
			Console.Write(d+", ");
		}
        int[] reversedDigits = ReverseArray(digits);
        Console.WriteLine("Reversed Digits: ");
		foreach(int d in reversedDigits)
		{
			Console.Write(d+", ");
		}
        if(IsPalindrome(number)){
			Console.WriteLine("Number is Palindrome");
		}else{
			Console.WriteLine("Number is not Palindrome");
		}
        if(IsDuckNumber(number)){
			Console.WriteLine("Number is a Duck Number");;
		}else{
			Console.WriteLine("Number is not a Duck Number");
		}
    }
}
