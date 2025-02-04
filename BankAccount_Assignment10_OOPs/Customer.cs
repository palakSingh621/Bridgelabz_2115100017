using System;
namespace BankAccount_Assignment_10
{
    //class Customer to save account holder information
    internal class Customer
    {
        public string customerName;
        private double currentBalance;
        private int accountNumber;

        public Customer(string customerName, int accountNumber, double currentBalance)
        {
            this.customerName = customerName;
            this.currentBalance = currentBalance;
            this.accountNumber = accountNumber;
        }
        public string CustomerName 
        { 
            get { return customerName; } 
        }
        public double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance= value; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
        }
    }
}
