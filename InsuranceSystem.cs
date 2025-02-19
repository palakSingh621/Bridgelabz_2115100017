using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment_20_Collections
{
    class InsurancePolicy
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }
        public InsurancePolicy(string policyNumber, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }
        public override bool Equals(object obj)
        {
            return obj is InsurancePolicy policy && PolicyNumber == policy.PolicyNumber;
        }
        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }
        public override string ToString()
        {
            return $"PolicyNumber: {PolicyNumber}, Coverage: {CoverageType}, Expiry: {ExpiryDate:yyyy-MM-dd}";
        }
    }
    class InsurancePolicySystem
    {
        private HashSet<InsurancePolicy> uniquePolicies = new HashSet<InsurancePolicy>();
        private LinkedList<InsurancePolicy> orderedPolicies = new LinkedList<InsurancePolicy>();
        private SortedDictionary<DateTime, List<InsurancePolicy>> sortedPolicies = new SortedDictionary<DateTime, List<InsurancePolicy>>();
        private Dictionary<string, List<InsurancePolicy>> duplicatePolicies = new Dictionary<string, List<InsurancePolicy>>();
        public void AddPolicy()
        {
            Console.Write("Enter Policy Number: ");
            string policyNumber = Console.ReadLine();
            Console.Write("Enter Coverage Type: ");
            string coverageType = Console.ReadLine();
            Console.Write("Enter Expiry Date (yyyy-MM-dd): ");
            DateTime expiryDate = DateTime.Parse(Console.ReadLine());
            InsurancePolicy policy = new InsurancePolicy(policyNumber, coverageType, expiryDate);
            if (!uniquePolicies.Add(policy))
            {
                if (!duplicatePolicies.ContainsKey(policyNumber))
                {
                    duplicatePolicies[policyNumber] = new List<InsurancePolicy>();
                }
                duplicatePolicies[policyNumber].Add(policy);
                Console.WriteLine("Duplicate policy detected!");
            }
            else
            {
                orderedPolicies.AddLast(policy);

                if (!sortedPolicies.ContainsKey(expiryDate))
                {
                    sortedPolicies[expiryDate] = new List<InsurancePolicy>();
                }
                sortedPolicies[expiryDate].Add(policy);

                Console.WriteLine("Policy added successfully!");
            }
        }
        public void ViewAllPolicies()
        {
            Console.WriteLine("\nAll Unique Policies:");
            foreach (var policy in uniquePolicies)
            {
                Console.WriteLine(policy);
            }
        }
        public void ViewExpiringSoon()
        {
            Console.WriteLine("\nPolicies Expiring Soon (Next 30 Days):");
            DateTime now = DateTime.Now;
            DateTime future = now.AddDays(30);

            foreach (var kvp in sortedPolicies)
            {
                if (kvp.Key >= now && kvp.Key <= future)
                {
                    foreach (var policy in kvp.Value)
                    {
                        Console.WriteLine(policy);
                    }
                }
            }
        }
        public void ViewByCoverageType()
        {
            Console.Write("\nEnter Coverage Type to Search: ");
            string type = Console.ReadLine();
            var filtered = uniquePolicies.Where(p => p.CoverageType.Equals(type, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nPolicies with Coverage Type: " + type);
            foreach (var policy in filtered)
            {
                Console.WriteLine(policy);
            }
        }
        public void ViewDuplicatePolicies()
        {
            Console.WriteLine("\nDuplicate Policies:");
            foreach (var kvp in duplicatePolicies)
            {
                Console.WriteLine($"Policy Number: {kvp.Key}");
                foreach (var policy in kvp.Value)
                {
                    Console.WriteLine("  " + policy);
                }
            }
        }
    }
    internal class InsuranceSystem
    {
        static void Main()
        {
            InsurancePolicySystem system = new InsurancePolicySystem();
            while (true)
            {
                Console.WriteLine("\nInsurance Policy Management System");
                Console.WriteLine("1. Add Policy");
                Console.WriteLine("2. View All Policies");
                Console.WriteLine("3. View Policies Expiring Soon (30 days)");
                Console.WriteLine("4. View Policies by Coverage Type");
                Console.WriteLine("5. View Duplicate Policies");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        system.AddPolicy();
                        break;
                    case "2":
                        system.ViewAllPolicies();
                        break;
                    case "3":
                        system.ViewExpiringSoon();
                        break;
                    case "4":
                        system.ViewByCoverageType();
                        break;
                    case "5":
                        system.ViewDuplicatePolicies();
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
