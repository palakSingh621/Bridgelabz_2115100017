using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    class Student
    {
        public string StudentName { get; set; }
        private List<Course> EnrolledCourses { get; set; }
        //Student Constructor
        public Student(string studentName)
        {
            StudentName = studentName;
            EnrolledCourses = new List<Course>();
        }
        //Method to enroll a student in course
        public void EnrollCourse(Course course)
        {
            EnrolledCourses.Add(course);
            course.AddStudent(this);
        }
        //Method to display course details
        public void DisplayCourses()
        {
            Console.WriteLine(StudentName + " is enrolled in the following courses: ");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine(course.CourseName);
            }
            Console.WriteLine();
        }
    }
    class Professor
    {
        public string ProfessorName { get; set; }
        private List<Course> AssignedCourses { get; set; }
        //Professor Constructor
        public Professor(string professorName)
        {
            ProfessorName = professorName;
            AssignedCourses = new List<Course>();
        }
        //Method to assign a course to professor
        public void AssignCourse(Course course)
        {
            AssignedCourses.Add(course);
            course.AssignProfessor(this);
        }
        // Method to dispaly Course details
        public void DisplayCourses()
        {
            Console.WriteLine(ProfessorName + " is assigned to the following courses:");
            foreach (var course in AssignedCourses)
            {
                Console.WriteLine(course.CourseName);
            }
            Console.WriteLine();
        }
    }
    class Course
    {
        public string CourseName { get; set; }
        private List<Student> Students { get; set; }
        private List<Professor> Professors { get; set; }
        //Course Constructor
        public Course(string courseName)
        {
            CourseName = courseName;
            Students = new List<Student>();
            Professors = new List<Professor>();
        }
        //method to add student
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        //method to add professor
        public void AssignProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine();
            Console.WriteLine("Students enrolled:");
            foreach (var student in Students)
            {
                Console.WriteLine(student.StudentName);
            }
            Console.WriteLine();
            Console.WriteLine("Professors assigned:");
            foreach (var professor in Professors)
            {
                Console.WriteLine(professor.ProfessorName);
            }
            Console.WriteLine();
        }
    }
    class University
    {
        public string UniversityName { get; set; }
        private List<Student> Students { get; set; }
        private List<Professor> Professors { get; set; }
        private List<Course> Courses { get; set; }
        //University Constructor
        public University(string universityName)
        {
            UniversityName = universityName;
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
        }
        //Method to add student
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("University Name: " + UniversityName);
            Console.WriteLine();
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                Console.WriteLine(student.StudentName);
            }
            Console.WriteLine();
            Console.WriteLine("Professors:");
            foreach (var professor in Professors)
            {
                Console.WriteLine(professor.ProfessorName);
            }
            Console.WriteLine();    
            Console.WriteLine("Courses:");
            foreach (var course in Courses)
            {
                course.DisplayDetails();
            }
            Console.WriteLine(); 
        }
    }
    internal class UniversityManagementSystem
    {
        static void Main(string[] args)
        {
            University university = new University("GLA University");
            Student student1 = new Student("Palak");
            Student student2 = new Student("Anshika");
            Professor professor1 = new Professor("Dr. Praveen Mittal");
            Professor professor2 = new Professor("Dr. Mayank Shrivastav");
            Course course1 = new Course("Operating System");
            Course course2 = new Course("DBMS");
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddProfessor(professor1);
            university.AddProfessor(professor2);
            university.AddCourse(course1);
            university.AddCourse(course2);
            student1.EnrollCourse(course1);
            student1.EnrollCourse(course2);
            student2.EnrollCourse(course2);
            professor1.AssignCourse(course1);
            professor2.AssignCourse(course2);
            university.DisplayDetails();
        }
    }
}
