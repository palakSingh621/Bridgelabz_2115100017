using System;
class OddEven
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i+" is an even number.");
                else
                    Console.WriteLine(i+" is an odd number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive number");
        }
    }
}
