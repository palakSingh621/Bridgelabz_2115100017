using System;
class SumOfNatural
{
    // Method to calculate the sum of n natural numbers recursively
    public static int RecursiveSum(int n)
    {
        if (n == 1)
            return 1;
        return n + RecursiveSum(n - 1);
    }
    // Method to calculate the sum of n natural numbers using the formula
    public static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
		int n=Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        int recursiveResult = RecursiveSum(n);
        int formulaResult = FormulaSum(n);
        Console.WriteLine("Sum of first "+n+" natural numbers using recursion: "+recursiveResult);
        Console.WriteLine("Sum of first "+n+" natural numbers using formula: "+formulaResult);
        // comparing results
        if (recursiveResult == formulaResult)
        {
            Console.WriteLine("Results matched!");
        }
        else
        {
            Console.WriteLine("Results mismatched!");
        }
    }
}
