using System;
namespace Assignment_21_Exceptions
{
    // Custom Exception for Insufficient Funds
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
    class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful, new balance: {Balance}");
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                // Initialize bank account with a balance of 1000
                BankAccount account = new BankAccount(1000);

                // Get withdrawal amount from the user
                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());

                // Attempt to withdraw
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numeric value.");
            }
        }
    }
}
