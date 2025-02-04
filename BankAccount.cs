using System;
namespace Assignment_10
{
    internal class BankAccount
    {
        //attributes
        private static string bankName="Global Bank";
        private string AccountHolderName;
        private readonly int AccountNumber;
        private static int totalAccounts = 0;
        private double AccountBalance;
        //Constructor
        public BankAccount(string AccountHolderName, int AccountNumber, double AccountBalance)
        {
            this.AccountHolderName = AccountHolderName; 
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;
            totalAccounts++;    
        }
        //Static Method to keep the count of the accounts created 
        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }
        //Method to display Accounts
        public void DisplayAccounts()
        {
            if (this is BankAccount)
            {
                Console.WriteLine("BankName: " + bankName);
                Console.WriteLine("Account Holder Name: " + AccountHolderName);
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Current Balance: " + AccountBalance);
            }
            else
            {
                Console.WriteLine("Invalid account object");
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Palak", 57346, 567000.00);
            BankAccount acc2 = new BankAccount("Anju", 876354, 75000.00);
            acc1.DisplayAccounts();
            Console.WriteLine();
            acc2.DisplayAccounts();
            Console.WriteLine();
            Console.WriteLine("Total number of Accounts: " + BankAccount.GetTotalAccounts());
        }
    }
}
