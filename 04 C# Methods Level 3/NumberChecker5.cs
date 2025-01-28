using System;
class NumberChecker5
{
    // Method to check if a number is a prime number
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    // Method to check if a number is a neon number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }
    // Method to check if a number is a spy number
    public static bool IsSpy(int number)
    {
        int sum = 0, product = 1;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }
    // Method to check if a number is an automorphic number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        string numberStr = number.ToString();
        string squareStr = square.ToString();
        return squareStr.EndsWith(numberStr);
    }
    // Method to check if a number is a buzz number
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        // Check if the number is a prime number
        if(IsPrime(number)){
			Console.WriteLine("Number is Prime");
		}else{
			Console.WriteLine("Number is not Prime");
		}
        // Check if the number is a neon number
		if(IsNeon(number)){
			Console.WriteLine("Number is Neon");
		}else{
			Console.WriteLine("Number is not Neon");
		}
        // Check if the number is a spy number
        if(IsSpy(number)){
			Console.WriteLine("Number is a spy number");
		}else{
			Console.WriteLine("Number is not a spy number");
		}
        // Check if the number is an automorphic number
        if(IsAutomorphic(number)){
			Console.WriteLine("Number is Automorphic");
		}else{
			Console.WriteLine("Number is not Automorphic");
		}
        // Check if the number is a buzz number
        if(IsBuzz(number)){
			Console.WriteLine("Number is a Buzz Number");
		}else{
			Console.WriteLine("Number is not a Buzz Number");
		}
    }
}
