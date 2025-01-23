using System;
class FactorsFinder
{
    public static void Main(String[] args)
    {
        // taking the user to enter an integer value
        Console.WriteLine("Please enter an integer to find its factors:");
        int userInput = int.Parse(Console.ReadLine());

        // Display the factors of the input number
        Console.WriteLine("The divisors of " + userInput + " are:");

        // Iterate from 1 to the number to check for factors
        for (int divisor = 1; divisor <= userInput; divisor++)
        {
            if (userInput % divisor == 0) // Check if 'divisor' is a factor
            {
                Console.WriteLine(divisor); // Print the factor
            }
        }
    }
}
