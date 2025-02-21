using System;
namespace Assignment_21_Exceptions
{
    class Program9
    {
        static void Main()
        {
            try
            {
                // Define an array
                int[] numbers = { 10, 20, 30, 40, 50 };

                // Get user input for index
                Console.Write("Enter the index of the element to access: ");
                int index = int.Parse(Console.ReadLine());

                try
                {
                    // Attempt to access the array element
                    int value = numbers[index];

                    // Get user input for divisor
                    Console.Write("Enter the divisor: ");
                    int divisor = int.Parse(Console.ReadLine());

                    try
                    {
                        // Perform division
                        int result = value / divisor;
                        Console.WriteLine($"Result: {result}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid array index!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
        }
    }
}
