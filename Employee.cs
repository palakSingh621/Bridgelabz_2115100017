using System;
namespace Constructors_Assignment
{
    internal class Employee
    {
        //Attributes
        public int employeeID;
        protected string department;
        private double salary;
        //Constructor
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }
        //Updating salary
        public void updateSalary()
        {
            Console.Write("Enter the new salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        //displaying the details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee Number: " + employeeID);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary)
        {
        }
        public void updateEmployeeID()
        {
            Console.Write("Enter the new Employee ID: ");
            employeeID = Convert.ToInt32(Console.ReadLine());
        }
        public void updateDepartment()
        {
            Console.WriteLine("Enter the new designated department: ");
            department = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
        }
    }
    class program14
    {
        public static void Main(String[] args)
        {
            Employee employee1 = new Employee(789, "Testing", 88000.00);
            employee1.DisplayDetails();
            Console.WriteLine();
            employee1.updateSalary();
            employee1.DisplayDetails();
            Console.WriteLine();
            Manager employee2 = new Manager(654, "Software Development", 170000);
            employee2.DisplayDetails();
            Console.WriteLine();
            employee2.updateEmployeeID(); // accessing employee ID in sub class
            employee2.DisplayDetails();
            Console.WriteLine();
            employee2.updateDepartment(); // accessing department in sub class
            employee2.DisplayDetails();
        }
    }
}
