using System;
namespace Assignment_21_Exceptions
{
    // Custom exception class
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class Program3
    {
        // Method to validate age
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above.");
            }
            Console.WriteLine("Access granted!");
        }

        static void Main()
        {
            try
            {
                // Take user input
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Validate age
                ValidateAge(age);
            }
            catch (InvalidAgeException ex)
            {
                // Handle custom exception
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                // Handle non-numeric input
                Console.WriteLine("Error: Please enter a valid numeric age.");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
