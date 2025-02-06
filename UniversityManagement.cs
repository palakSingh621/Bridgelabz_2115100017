using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    class Faculty
    {
        //Faculty Attributes
        public string FacultyName { get; set; }
        public Faculty(string facultyName)
        {
            FacultyName = facultyName;
        }
        // Method to display Faculty Names
        public void DisplayDetails()
        {
            Console.WriteLine("Faculty Name: " + FacultyName);
        }
    }
    class Department
    {
        // University Department attributes 
        public string DepartmentName { get; set; }
        private List<Faculty> Faculties { get; set; }
        // Department Constructor
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Faculties = new List<Faculty>();
        }
        // Method to add faculty in university staff
        public void AddFaculty(Faculty faculty)
        {
            Faculties.Add(faculty);
        }
        // Method to display department details
        public void DisplayDetails()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            foreach (var faculty in Faculties)
            {
                faculty.DisplayDetails();
            }
            Console.WriteLine();
        }
    }
    class University
    {
        public string UniversityName { get; set; }
        private List<Department> Departments { get; set; }
        //University Constructor
        public University(string universityName)
        {
            UniversityName = universityName;
            Departments = new List<Department>();
        }
        //Method to add department 
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        //Method to display deparment details 
        public void DisplayDetails()
        {
            Console.WriteLine("University Name: " + UniversityName);
            foreach (var department in Departments)
            {
                department.DisplayDetails();
            }
            Console.WriteLine();
        }
    }
    internal class UniversityManagement
    {
        static void Main()
        {
            University university = new University("Tech University");
            Department dept1 = new Department("Computer Science");
            Department dept2 = new Department("Electrical Engineering");
            Faculty fac1 = new Faculty("Dr.Rambhag");
            Faculty fac2 = new Faculty("Dr.Atul ");
            dept1.AddFaculty(fac1);
            dept2.AddFaculty(fac2);
            university.AddDepartment(dept1);
            university.AddDepartment(dept2);
            university.DisplayDetails();
            fac1.DisplayDetails();
        }
    }
}
