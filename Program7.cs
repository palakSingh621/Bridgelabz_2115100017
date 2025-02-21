using System;
namespace Assignment_21_Exceptions
{
    class Program7
    {
        static void Main()
        {
            try
            {
                // Taking user input
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                // Performing division
                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
            finally
            {
                // Finally block always executes
                Console.WriteLine("Operation completed.");
            }
        }
    }
}
