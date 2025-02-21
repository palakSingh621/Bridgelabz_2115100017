using System;
namespace Assignment_21_Exceptions
{
    class Program2
    {
        static void Main()
        {
            try
            {
                // Prompt user for input
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                // Perform division
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                // Handle non-numeric input
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
