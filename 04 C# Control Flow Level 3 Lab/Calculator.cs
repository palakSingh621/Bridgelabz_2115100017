using System;
class Calculator
{
    public static void Main(string[] args)
    {	
		Console.Write("Enter the number: ");
        double number = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0;i<number;i++){
			
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();
        switch (op)
        {
            case "+":
				double add = first + second;
                Console.WriteLine("Result "+add);
                break;

            case "-":
				double sub = first - second;
                Console.WriteLine("Result "+ sub);
                break;

            case "*":
				double product = first * second;
                Console.WriteLine("Result "+ product);
                break;
			case "/":
                if (second != 0)
                {
					double div = first / second;
                    Console.WriteLine("Result "+ div);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
	}
}