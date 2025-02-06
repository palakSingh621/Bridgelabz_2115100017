using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    //Customer class 
    public class Customer
    {
        public string Name;
        public Bank Bank;
        public double Balance;
        // Constructor
        public Customer(string name)
        {
            this.Name = name;
        }
        //Display Balance method
        public void ViewBalance()
        {
            Console.WriteLine("The balance of " + Name + " is " + Balance);
        }
    }
    //Bank class
    public class Bank
    {
        public string BankName;
        private List<Customer> customers = new List<Customer>();
        // Method to open customer account in bank 
        public void OpenAccount(Customer customer, double initialDeposit)
        {
            customer.Bank = this;
            customer.Balance = initialDeposit;
            customers.Add(customer);
            Console.WriteLine("Opened an account for " + customer.Name + " in the bank " + BankName + " with balance " + initialDeposit);
            Console.WriteLine();
        }
        //Method to display customer details
        public void DisplayDetails()
        {
            Console.WriteLine("Customers of " + BankName + ":");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("Name: " + customers[i].Name + ", Balance: " + customers[i].Balance);
            }
            Console.WriteLine();
        }
    }
    // Main method class
    internal class BankAccount
    {
        static void Main(string[] args)
        {
            Bank myBank1 = new Bank { BankName = "Yes Bank" };
            Bank myBank2 = new Bank { BankName = "SBI" };
            Customer customer1 = new Customer("Palak");
            Customer customer2 = new Customer("Yash");

            myBank1.OpenAccount(customer1, 75000);
            myBank1.OpenAccount(customer2, 10000);
            myBank2.OpenAccount(customer1, 30000);
            myBank1.DisplayDetails();
            myBank2.DisplayDetails();
            customer1.ViewBalance();
            customer2.ViewBalance();
        }
    }
}
