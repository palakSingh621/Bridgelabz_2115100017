using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment_20_Collections
{
    class BankingSystem
    {
        private Dictionary<int, double> accounts = new Dictionary<int, double>(); // Account Number -> Balance
        private Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>(); // Queue for withdrawals

        // Add a new account
        public void AddAccount()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accNumber) || accNumber <= 0)
            {
                Console.WriteLine("Invalid account number! Try again.");
                return;
            }

            Console.Write("Enter Initial Balance: ");
            if (!double.TryParse(Console.ReadLine(), out double balance) || balance < 0)
            {
                Console.WriteLine("Invalid balance! Try again.");
                return;
            }

            if (accounts.ContainsKey(accNumber))
            {
                Console.WriteLine("Account already exists! Try another account number.");
                return;
            }

            accounts[accNumber] = balance;
            Console.WriteLine($"Account {accNumber} created with balance: ${balance:F2}");
        }

        // Deposit money
        public void Deposit()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accNumber) || !accounts.ContainsKey(accNumber))
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.Write("Enter Deposit Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount! Try again.");
                return;
            }

            accounts[accNumber] += amount;
            Console.WriteLine($"Deposited ${amount:F2} into Account {accNumber}. New Balance: ${accounts[accNumber]:F2}");
        }

        // Request withdrawal (added to queue)
        public void RequestWithdrawal()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accNumber) || !accounts.ContainsKey(accNumber))
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.Write("Enter Withdrawal Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount! Try again.");
                return;
            }

            withdrawalQueue.Enqueue(new Tuple<int, double>(accNumber, amount));
            Console.WriteLine($"Withdrawal request of ${amount:F2} from Account {accNumber} added to queue.");
        }

        // Process withdrawals (FIFO)
        public void ProcessWithdrawals()
        {
            if (withdrawalQueue.Count == 0)
            {
                Console.WriteLine("No withdrawal requests in queue.");
                return;
            }

            while (withdrawalQueue.Count > 0)
            {
                var request = withdrawalQueue.Dequeue();
                int accNumber = request.Item1;
                double amount = request.Item2;

                if (accounts.ContainsKey(accNumber) && accounts[accNumber] >= amount)
                {
                    accounts[accNumber] -= amount;
                    Console.WriteLine($"Processed withdrawal of ${amount:F2} from Account {accNumber}. New Balance: ${accounts[accNumber]:F2}");
                }
                else
                {
                    Console.WriteLine($"Failed: Insufficient funds in Account {accNumber} or account does not exist.");
                }
            }
        }

        // Display accounts sorted by balance
        public void DisplaySortedAccounts()
        {
            SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>(
                accounts.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value));

            Console.WriteLine("\nAccounts Sorted by Balance:");
            foreach (var acc in sortedAccounts)
            {
                Console.WriteLine($"Account {acc.Key}: ${acc.Value:F2}");
            }
        }
    }
    internal class Banking
    {
        static void Main()
        {
            BankingSystem bank = new BankingSystem();

            while (true)
            {
                Console.WriteLine("\nBanking System Menu");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Request Withdrawal");
                Console.WriteLine("4. Process Withdrawals");
                Console.WriteLine("5. Display Accounts (Sorted by Balance)");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        bank.AddAccount();
                        break;
                    case "2":
                        bank.Deposit();
                        break;
                    case "3":
                        bank.RequestWithdrawal();
                        break;
                    case "4":
                        bank.ProcessWithdrawals();
                        break;
                    case "5":
                        bank.DisplaySortedAccounts();
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
