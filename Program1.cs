using System;
using System.Collections.Generic;
namespace Assignment_13_Encapsulation
{
    abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => baseSalary; set => baseSalary = value; }

        public Employee(int id, string name, double salary)
        {
            this.EmployeeId = id;
            this.Name = name;
            this.Salary = salary;
        }
        public abstract double CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }
    interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }
    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;
        public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }

        public override double CalculateSalary()
        {
            return Salary;
        }
        public void AssignDepartment(string department)
        {
            this.department = department;
        }
        public string GetDepartmentDetails()
        {
            return $"{Name} works in {department} department.";
        }
    }
    class PartTimeEmployee : Employee, IDepartment
    {
        private double hourlyRate;
        private int hourWorked;
        private string department;

        public PartTimeEmployee(int id, string name, double hourlyRate, int hourWorked) : base(id, name, 0)
        {
            this.hourlyRate = hourlyRate;
            this.hourWorked = hourWorked;
        }
        public override double CalculateSalary()
        {
            return hourlyRate * hourWorked;
        }
        public void AssignDepartment(string department)
        {
            this.department = department;
        }
        public string GetDepartmentDetails()
        {
            return $"{Name} works in {department} department.";
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            // List of employees (Polymorphism)
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(1, "Palak", 50000),
                new PartTimeEmployee(2, "Yash", 20, 120)
            };
            // Assigning departments
            ((IDepartment)employees[0]).AssignDepartment("HR");
            ((IDepartment)employees[1]).AssignDepartment("IT");
            // Display details
            foreach (var emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine(((IDepartment)emp).GetDepartmentDetails());
                Console.WriteLine();
            }
        }
    }
}
