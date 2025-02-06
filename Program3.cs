using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    class Employee
    {
        // attributes
        public string Name { get; set; }
        public string Position { get; set; }
        // Constructor
        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }
        // Display Details of employee
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Position: " + Position);
        }
    }
    class Department
    {
        //attributes
        string DepartmentName { get; set; }
        private List<Employee> Employees { get; set; }
        //Department Constructor
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Employees = new List<Employee>();
        }
        //Method to Add Employee to the department
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        // Method to display employee list in the department
        public void DisplayDetails()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine();
            foreach (var employee in Employees)
            {
                employee.DisplayDetails();
            }
            Console.WriteLine();
        }
    }
    class Company
    {
        //attributes
        public string CompanyName { get; set; }
        private List<Department> Departments { get; set; }
        // Company Constructor
        public Company(string companyName)
        {
            CompanyName = companyName;
            Departments = new List<Department>();
        }
        //Method to add department to a company
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        //display Comapny details
        public void DisplayDetails()
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine();
            foreach (var department in Departments)
            {
                department.DisplayDetails();
            }
            Console.WriteLine();
        }
    }
    internal class Program3
    {
        static void Main()
        {
            Company company = new Company("Capgemini");
            Department dept1 = new Department("Technical Department");
            Department dept2 = new Department("Consulting Department");
            Employee emp1 = new Employee("Palak", "Engineer");
            Employee emp2 = new Employee("Anju", "Consultant Manager");
            dept1.AddEmployee(emp1);
            dept2.AddEmployee(emp2);
            company.AddDepartment(dept1);
            company.AddDepartment(dept2);
            company.DisplayDetails();
            company = null;
        }
    }
}
