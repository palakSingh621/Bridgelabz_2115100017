using System;
class Factors
{
    // Method to Calculate factors of a number and storing them in an array
    public static int[] FindFactors(int number)
    {
        int count = 0;
        // First loop to count the number of factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }
        return factors;
    }
    // Method to calculate the sum of factors
    public static int CalculateSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }
    // Method to calculate the product of factors
    public static double CalculateProduct(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
    // Method to calculate the sum of squares of factors
    public static double CalculateSumOfSquares(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors:");
        foreach (int factor in factors)
        {
            Console.WriteLine(factor+", ");
        }
        int sum = CalculateSum(factors);
        double product = CalculateProduct(factors);
        double sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine("Sum of Factors: "+sum);
        Console.WriteLine("Product of Factors: "+product);
        Console.WriteLine("Sum of Squares of Factors: "+sumOfSquares);
    }
}