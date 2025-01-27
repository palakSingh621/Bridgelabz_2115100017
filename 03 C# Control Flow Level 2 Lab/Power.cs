using System;
    class Power
    {
        public static void Main(String[] args)
        {
            // taking the user to enter the base number
            Console.WriteLine("Enter the base value:");
            int baseValue = int.Parse(Console.ReadLine());

            // taking the user to enter the exponent value
            Console.WriteLine("Enter the exponent:");
            int exponentValue = int.Parse(Console.ReadLine());

            // Initialize a variable to store the result of the calculation
            int powerResult = 1;

            // Loop to calculate the base raised to the power of the exponent
            for (int counter = 1; counter <= exponentValue; counter++)
            {
                powerResult *= baseValue; // Multiply the result by the base value in each iteration
            }

            // Display the result
            Console.WriteLine("The result of " + baseValue + " raised to the power of " + exponentValue + " is " + powerResult + ".");
        }
    }
}
