using System;
class Bonus
{
    public static void Main(String[] args)
    {
		// Taking salary input from the user
        Console.Write("Enter the salary: ");
		double salary=Convert.ToDouble(Console.ReadLine());
        if (salary > 0)
        {
			// Taking years of service in years as input from the user
            Console.Write("Enter the years of service: ");
			int yearsOfService=Convert.ToInt32(Console.ReadLine());
            if (yearsOfService > 0)
            {
                if (yearsOfService > 5)
                {
                    double bonus = salary * 0.05;
                    Console.WriteLine("Bonus amount is: "+bonus);
                }
                else
                {
                    Console.WriteLine("No bonus for less than 5 years of service.");
                }
            }
            else
            {
                Console.WriteLine("Invalid years of service.");
            }
        }
        else
        {
            Console.WriteLine("Invalid salary amount.");
        }
    }
}
