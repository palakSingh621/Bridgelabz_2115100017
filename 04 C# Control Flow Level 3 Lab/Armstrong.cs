using System;
class Armstrong
{
    public static void Main(string[] args)
    {
        // taking user to enter a number
        Console.Write("Enter a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Variables for digit count, temporary number, and calculation
        int numberOfDigits = 0;
        int tempNumber = userInput;
        int calculatedValue = 0;
        int currentDigit = 0;

        // Calculate the number of digits in the input number
        while (tempNumber > 0)
        {
            tempNumber /= 10;
            numberOfDigits++;
        }

        // Reset tempNumber to the original input value
        tempNumber = userInput;

        // Calculate the Armstrong value
        while (tempNumber > 0)
        {
            currentDigit = tempNumber % 10; // Extract the last digit
            calculatedValue += (int)Math.Pow(currentDigit, numberOfDigits); // Add the power of the digit
            tempNumber /= 10; // Remove the last digit
        }

        // Check and display whether the number is an Armstrong number
        if (calculatedValue == userInput)
        {
            Console.WriteLine(userInput + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(userInput + " is not an Armstrong number.");
        }
    }
}
