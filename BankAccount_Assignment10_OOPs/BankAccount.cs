using System;
namespace BankAccount_Assignment_10
{
    // Main method class
    internal class BankAccount
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            Customer account_holder1 = new Customer("Palak Singh", 87654321, 75000.00);
            Console.WriteLine("We are Thrilled to have you " +account_holder1.customerName+"!");
            while (true) 
            {
                Console.WriteLine("Service List: ");
                Console.WriteLine("1. Amount Deposite ");
                Console.WriteLine("2. Amount Withdrawal ");
                Console.WriteLine("3. Check Current Balance ");
                Console.WriteLine("4. Exit ");
                Console.WriteLine();
                Console.Write("Please Enter your Service number: ");
                string choice=Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the Amount to Deposite: ");
                        double deposite_Amount=Convert.ToDouble(Console.ReadLine());
                        bank.Deposite(deposite_Amount, account_holder1);
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Write("Enter the Amount to Withdraw: ");
                        double withdrawal_Amount = Convert.ToDouble(Console.ReadLine());
                        bank.WithDrawal(withdrawal_Amount, account_holder1);
                        Console.WriteLine();
                        break;
                    case"3":
                        bank.CheckBalance(account_holder1);
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Thank You for using our services! GoodBye!");
                        return ;
                        break;
                    default:
                        Console.WriteLine("Invalid service Choice");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
