using System;
    class LargestDivisor
    {
        public static void Main(String[] args)
        {
            // taking user for input
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            // Assigning Variable to store the largest divisor
            int largestDivisor = 1;

            // Loop to find the largest divisor other than the number itself
            for (int divisor = inputNumber - 1; divisor >= 1; divisor--)
            {
                // Check if the current divisor divides the number completely
                if (inputNumber % divisor == 0)
                {
                    largestDivisor = divisor;
                    break; // Exit loop once the largest divisor is found
                }
            }
            Console.WriteLine("The largest divisor of " + inputNumber + " (other than itself) is " + largestDivisor + ".");
        }
    }
}
