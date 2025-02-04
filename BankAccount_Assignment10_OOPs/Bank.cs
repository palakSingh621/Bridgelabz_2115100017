using System;
namespace BankAccount_Assignment_10
{
    //Class Bank with bank services methods
    internal class Bank
    {
        private static string bankName;
        private const double minimumBalance = 2000;

        public string BankName
        {
            set { bankName = value; }  
        }
        public Bank()
        {
            Console.Write("Please Enter the Bank Name: ");
            bankName = Console.ReadLine();
            Console.WriteLine("Welocome to " + bankName + " Bank!");
        }
        public void Deposite(double amount, Customer customer)
        {
            if(amount>0)
            {
                customer.CurrentBalance += amount;
                Console.WriteLine("You have successfully deposited " + amount + " Rupees. Now Your Current Balance is " + customer.CurrentBalance);
            }
            else
            {
                Console.WriteLine("invalid Amount input.");
            }
        }
        public void WithDrawal(double amount, Customer customer)
        {
            double checkBalance = customer.CurrentBalance - amount;
            if (checkBalance >= minimumBalance)
            {
                customer.CurrentBalance = checkBalance;
                Console.WriteLine("Successful Withdrawal of "+amount+" Rupees. Current balance is "+customer.CurrentBalance);
            }
            else
            {
                Console.WriteLine("Can't Withdraw "+amount+" Rupees. Minimimum limit to hold the Account is "+minimumBalance);
            }
        }
        public void CheckBalance(Customer customer)
        {
            Console.WriteLine("Your Current Balance is " + customer.CurrentBalance + " Rupees.");
        }
    }
}
