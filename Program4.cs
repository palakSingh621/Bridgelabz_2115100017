using System;
namespace Assignment_21_Exceptions
{
    class Program4
    {
        static void Main()
        {
            int[] numbers = null; // Simulating an uninitialized array

            try
            {
                // Accepting user input for the array
                Console.Write("Enter the size of the array: ");
                int size = int.Parse(Console.ReadLine());

                numbers = new int[size]; // Initializing the array

                // Populating the array
                Console.WriteLine("Enter the array elements:");
                for (int i = 0; i < size; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                // Accepting index input
                Console.Write("Enter the index to retrieve: ");
                int index = int.Parse(Console.ReadLine());
                // Retrieving and printing the value at the index
                Console.WriteLine($"Value at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numeric value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
