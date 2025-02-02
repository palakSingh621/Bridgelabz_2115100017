using System;
class Table
{
    public static void Main(String[] args)
    {
		//taking number input from user
        Console.Write("Enter a number: ");
		int number=Convert.ToInt32(Console.ReadLine());
		// calculating the multiplication table of number between 6-9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number+" * "+i+" = "+(number * i));
        }
	}
}