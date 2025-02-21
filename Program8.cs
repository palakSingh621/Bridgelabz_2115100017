using System;
namespace Assignment_21_Exceptions
{
    class Program8
    {
        static void Method1()
        {
            // Throws an ArithmeticException (division by zero)
            int result = 10 / 0;
        }

        static void Method2()
        {
            // Calls Method1(), allowing the exception to propagate
            Method1();
        }

        static void Main()
        {
            try
            {
                // Calls Method2(), which calls Method1()
                Method2();
            }
            catch (ArithmeticException)
            {
                // Handles the propagated exception
                Console.WriteLine("Handled exception in Main");
            }
        }
    }
}
