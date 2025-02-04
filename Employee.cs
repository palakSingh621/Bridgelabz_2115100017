using System;
namespace Assignment_10
{
    internal class Employee
    {
        //attributes
        public static string companyName="Capgemini";
        static int totalEmployee = 0;
        string name;
        readonly int id;
        string designation;
        //constructor
        public Employee(string name, int id, string designation)
        {
            this.name=name;
            this.id=id;
            this.designation=designation;
            totalEmployee++;
        }
        //Method to get total employee number
        public static int DisplayTotalEmployees()
        {
            return totalEmployee;
        }
        //Method to display Employee details
        public void DisplayEmployees()
        {
            if (this is Employee)
            {
                Console.WriteLine("Employee ID: " + id);
                Console.WriteLine("Employee Name: " + name);
                Console.WriteLine("Designation: " + designation);
            }
            else
            {
                Console.WriteLine("Object Instance doesn't match");
            }
        }
    }
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comapany Name: " + Employee.companyName);
            Console.WriteLine();
            Employee emp1 = new Employee("Palak", 123, "SDE");
            emp1.DisplayEmployees();
            Console.WriteLine();
            Employee emp2 = new Employee("Subham", 783, "Manager");
            emp2.DisplayEmployees();
            Console.WriteLine();
            Console.WriteLine("Total number of employees: " + Employee.DisplayTotalEmployees());

        }
    }
}
