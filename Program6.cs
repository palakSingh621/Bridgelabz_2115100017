using System;
namespace Assignment_21_Exceptions
{
    class Program6
    {
        // Method to calculate interest
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Amount and rate must be positive.");
            }
            return amount * rate * years / 100; // Simple interest formula
        }
        static void Main()
        {
            try
            {
                // Taking user input
                Console.Write("Enter the principal amount: ");
                double amount = double.Parse(Console.ReadLine());
                Console.Write("Enter the interest rate: ");
                double rate = double.Parse(Console.ReadLine());
                Console.Write("Enter the number of years: ");
                int years = int.Parse(Console.ReadLine());
                // Calculating interest
                double interest = CalculateInterest(amount, rate, years);
                Console.WriteLine($"Calculated Interest: {interest}");
            }
            catch (ArgumentException ex)
            {
                // Handling invalid input
                Console.WriteLine("Invalid input: " + ex.Message);
            }
            catch (FormatException)
            {
                // Handling non-numeric input
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                // Handling any other unexpected errors
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
