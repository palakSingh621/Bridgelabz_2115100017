using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    interface ILoanable
    {
        void ApplyForLoan();
        void CalculateLoanEligibility();
    }
    internal abstract class BankAccount
    {
        //Attributes
        protected string accountNumber { get; }
        protected string holderName { get; set; }
        protected double balance { get; set; }
        //Constructor
        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }
        //concrete method to Deposit
        public void Deposit(double value)
        {
            balance += value;
        }
        //concrete method to withdraw
        public void Withdraw(double value)
        {
            if ((balance - value) < 2000)
            {
                Console.WriteLine("You need to maintain at least a balance of 2000!");
            }
            else
            {
                balance -= value;
            }
        }
        //method to check balance
        public void CheckBalance()
        {
            Console.WriteLine("The balance of this account is " + balance);
        }
        //abstract method to calculate interest
        public abstract void CalculateInterest();
    }
    class SavingsAccount : BankAccount, ILoanable
    {
        //Constructor
        public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance)
        {
        }
        //concrete method to calculate interest for Savings account
        public override void CalculateInterest()
        {
            double interest = 0.07 * balance;
            Console.WriteLine("The interest for this savings account is " + interest);
        }
        public void ApplyForLoan()
        {
            Console.WriteLine("Loan application submitted for savings account " + accountNumber);
        }
        public void CalculateLoanEligibility()
        {
            double eligibility = balance * 0.5;
            Console.WriteLine("Loan eligibility for savings account " + accountNumber + " is " + eligibility);
        }
    }
    class CurrentAccount : BankAccount, ILoanable
    {
        //Constructor
        public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance)
        {
        }
        //concrete method to calculate interest for current account
        public override void CalculateInterest()
        {
            double interest = 0.05 * balance;
            Console.WriteLine("The interest for this current account is " + interest);
        }
        public void ApplyForLoan()
        {
            Console.WriteLine("Loan application submitted for current account " + accountNumber);
        }
        public void CalculateLoanEligibility()
        {
            double eligibility = balance * 0.3;
            Console.WriteLine("Loan eligibility for current account " + accountNumber + " is " + eligibility);
        }
    }
    class program3
    {
        public static void Main(String[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount> {
                new SavingsAccount("101","Palak",187111834),
                new CurrentAccount("102","Yash",10000)
            };
            foreach (BankAccount bankaccount in bankAccounts)
            {
                bankaccount.CalculateInterest();
                bankaccount.CheckBalance();
                bankaccount.Deposit(100);
                bankaccount.CheckBalance();
                bankaccount.Withdraw(50);
                bankaccount.CheckBalance();
                if (bankaccount is ILoanable loanableAccount)
                {
                    loanableAccount.ApplyForLoan();
                    loanableAccount.CalculateLoanEligibility();
                }
            }
        }
    }
}
