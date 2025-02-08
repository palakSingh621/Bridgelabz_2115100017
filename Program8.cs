using System;
namespace Assignment_12_Inheritance
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public virtual void DisplayAccountType()
        {
            Console.WriteLine("This is a generic bank account.");
        }
    }
    // Derived class SavingsAccount
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Savings Account.");
        }
    }
    // Derived class CheckingAccount
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Checking Account.");
        }
    }
    // Derived class FixedDepositAccount
    class FixedDepositAccount : BankAccount
    {
        public int TermLength { get; set; }

        public FixedDepositAccount(string accountNumber, double balance, int termLength)
            : base(accountNumber, balance)
        {
            TermLength = termLength;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Fixed Deposit Account.");
        }
    }
    internal class Program8
    {
        static void Main()
        {
            BankAccount savings = new SavingsAccount("SA12345", 5000, 3.5);
            BankAccount checking = new CheckingAccount("CA67890", 2000, 1000);
            BankAccount fixedDeposit = new FixedDepositAccount("FD54321", 10000, 12);
            savings.DisplayAccountType();
            checking.DisplayAccountType();
            fixedDeposit.DisplayAccountType();
        }
    }
}
