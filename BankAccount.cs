using System;
namespace Constructors_Assignment
{
    internal class BankAccount
    {
        //Attributes
        public int accountNumber;
        protected string accountHolder;
        private double accountBalance;
        //Constructor
        public BankAccount(int accountNumber, string accountHolder, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.accountBalance = accountBalance;
        }
        //updating the balance
        public void updateBalance()
        {
            Console.Write("Enter the new balance: ");
            accountBalance = Convert.ToDouble(Console.ReadLine());
        }
        //Displaying the details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Account Balance: " + accountBalance);
        }
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, string accountHolder, double accountBalance) : base(accountNumber, accountHolder, accountBalance)
        {
        }
        public void updateAccountNumber()
        {
            Console.Write("Enter the new Account Number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void updateAccountHolder()
        {
            Console.Write("Enter the new Account Holder: ");
            accountHolder = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
        }
    }
    class program13
    {
        public static void Main(String[] args)
        {
            BankAccount account1 = new BankAccount(123, "Palak", 80000);
            account1.DisplayDetails();
            Console.WriteLine();
            account1.updateBalance();
            account1.DisplayDetails();
            Console.WriteLine();
            SavingsAccount account2 = new SavingsAccount(654, "Yash", 100000);
            account2.DisplayDetails();
            Console.WriteLine();
            account2.updateBalance(); // accessing balance in sub class
            account2.DisplayDetails();
            Console.WriteLine();
            account2.updateAccountHolder(); // accessing account holder in sub class
            account2.DisplayDetails();
        }
    }
}
