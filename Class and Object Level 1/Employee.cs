using System;

namespace Object_and_Classes
{
    internal class Employee
    {
        // Fields (Attributes)
        private string name;
        private int id;
        private double salary;

        // Constructor
        public Employee(string name, int id, double salary)
        {
            this.name = name;   
            this.id = id;   
            this.salary = salary;
        }
        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Salary: " + salary);
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Rajesh", 234, 30000.00);
            Employee emp2 = new Employee("Palak", 167, 75000.00);
            Console.WriteLine("Employee Detais: ");
            Console.WriteLine();
            Console.WriteLine("Employee 1 Details:");
            emp1.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Employee 2 Details: ");
            emp2.DisplayDetails();
        }
    }
}
