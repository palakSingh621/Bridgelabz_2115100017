using System;
class DigitFrequency
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt64(Console.ReadLine());
        // Convert the number to a string to easily count digits
        string numberStr = number.ToString();
        // Create an array to store the frequency of each digit 
        int[] frequency = new int[10];
        // Loop through the number string and count the frequency of each digit
        foreach (char digit in numberStr)
        {
			// Convert the char to its integer value
            int digitValue = digit - '0'; 
            frequency[digitValue]++;
        }
        // Displaying
        Console.WriteLine("\nFrequency of each digit:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + ": " + frequency[i] + " times");
            }
        }
    }
}