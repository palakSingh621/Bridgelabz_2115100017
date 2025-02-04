using System;
namespace Assignment_10
{
    internal class Student
    {
        //attributes
        static string universityName = "GLA University";
        static int totalStudents = 0;
        string name;
        readonly int rollNumber;
        char grade;
        //Constructor
        public Student(string name, int rollNumber, char grade)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.grade = grade;
            totalStudents++;
        }
        //Method to diaplsy total students in University
        public static int DisplayTotalStudents()
        {
            return totalStudents;
        }
        // Ststic get method to return universityName
        public static string GetUniversityName()
        {
            return universityName;
        }
        //Method to Display Student details
        public void DispalyStudent()
        {
            if (this is Student)
            {
                Console.WriteLine("Sudent Name: " + name);
                Console.WriteLine("Roll Number: " + rollNumber);
                Console.WriteLine("Grade: " + grade);
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Incorrect Onject Instance");
            }
        }
    }
    class Product5
    {
        static void Main(string[] args)
        {
            Student student_1 = new Student("Palak", 2115100017, 'B');
            Student student_2 = new Student("Anshika", 2115100005, 'A');
            Console.WriteLine("University Name: " + Student.GetUniversityName());
            Console.WriteLine();
            student_1.DispalyStudent();
            student_2.DispalyStudent();
            Console.WriteLine("Total Students in university: " + Student.DisplayTotalStudents());
        }
    }
}
