using System;
namespace Nunit_Assignment
{
    public class Calculator4
    {
        // Method to divide two numbers
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArithmeticException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
