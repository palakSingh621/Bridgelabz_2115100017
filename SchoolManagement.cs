using System;
using System.Collections.Generic;
namespace Assignment_11_OOPs
{
    class Course
    {
        //Course attributes
        public string CourseName { get; set; }
        private List<Student> EnrolledStudents { get; set; }
        // Course Costructor
        public Course(string courseName)
        {
            CourseName = courseName;
            EnrolledStudents = new List<Student>();
        }
        //Method to enroll the student
        public void EnrollStudent(Student student)
        {
            EnrolledStudents.Add(student);
        }
        //Method to display student details
        public void DisplayStudents()
        {
            Console.WriteLine("Students enrolled in " + CourseName + ": ");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
    class Student
    {
        //student attributes
        public string StudentName { get; set; }
        private List<Course> EnrolledCourses { get; set; }
        //studnet constructor
        public Student(string studentName)
        {
            StudentName = studentName;
            EnrolledCourses = new List<Course>();
        }
        //Method to enroll the student in the course
        public void EnrollInCourse(Course course)
        {
            EnrolledCourses.Add(course);
            course.EnrollStudent(this);
        }
        //Method to display Course details
        public void DisplayCourses()
        {
            Console.WriteLine(StudentName + " is enrolled in the following courses:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
    class School
    {
        //school attributes
        public string SchoolName { get; set; }
        private List<Student> Students { get; set; }
        //school constructor
        public School(string schoolName)
        {
            SchoolName = schoolName;
            Students = new List<Student>();
        }
        //Method to enroll student in the school
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        //Method to display student details
        public void DisplayStudents()
        {
            Console.WriteLine("Students in " + SchoolName + ":");
            foreach (var student in Students)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
    internal class SchoolManagement
    {
        static void Main()
        {
            School school = new School("St. George's College");
            Student student1 = new Student("Palak");
            Student student2 = new Student("Yash");
            Course course1 = new Course("Computer science");
            Course course2 = new Course("Science");
            school.AddStudent(student1);
            school.AddStudent(student2);
            student1.EnrollInCourse(course1);
            student1.EnrollInCourse(course2);
            student2.EnrollInCourse(course2);
            school.DisplayStudents();
            Console.WriteLine();
            student1.DisplayCourses();
            Console.WriteLine();
            student2.DisplayCourses();
            Console.WriteLine();
            course1.DisplayStudents();
            Console.WriteLine();
            course2.DisplayStudents();
        }
    }
}
