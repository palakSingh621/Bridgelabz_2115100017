using System;
using System.Collections.Generic;
namespace Assignment_20_Collections
{

    class VotingSystem
    {
        private Dictionary<string, int> voteCount = new Dictionary<string, int>(); // Stores votes
        private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(); // Displays sorted results
        private LinkedList<string> voteOrder = new LinkedList<string>(); // Maintains order of votes

        public void CastVote()
        {
            Console.Write("Enter candidate name: ");
            string candidate = Console.ReadLine();

            // Store votes in Dictionary
            if (voteCount.ContainsKey(candidate))
            {
                voteCount[candidate]++;
            }
            else
            {
                voteCount[candidate] = 1;
            }

            // Maintain order of voting
            voteOrder.AddLast(candidate);

            Console.WriteLine($"Vote cast for {candidate} successfully!");
        }

        public void DisplayResults()
        {
            Console.WriteLine("\nVoting Results (Sorted Order):");
            sortedVotes = new SortedDictionary<string, int>(voteCount);
            foreach (var kvp in sortedVotes)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");
            }
        }

        public void DisplayVotingOrder()
        {
            Console.WriteLine("\nOrder of Votes Cast:");
            foreach (var candidate in voteOrder)
            {
                Console.Write($"{candidate} -> ");
            }
            Console.WriteLine("END");
        }
    }
    internal class Voting
    {
        static void Main()
        {
            VotingSystem votingSystem = new VotingSystem();

            while (true)
            {
                Console.WriteLine("\nVoting System Menu");
                Console.WriteLine("1. Cast Vote");
                Console.WriteLine("2. Display Voting Results (Sorted)");
                Console.WriteLine("3. Display Order of Votes Cast");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        votingSystem.CastVote();
                        break;
                    case "2":
                        votingSystem.DisplayResults();
                        break;
                    case "3":
                        votingSystem.DisplayVotingOrder();
                        break;
                    case "4":
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
