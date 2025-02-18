using System;
using System.Collections.Generic;
namespace Assignment_19_Generics
{
    abstract class CourseType
    {
        //setting the attribute courseName
        public string CourseTypeName { get; set; }
    }

    class ExamCourse : CourseType
    {
        public ExamCourse()
        {
            CourseTypeName = "Exam Course";
        }
    }

    class AssignmentCourse : CourseType
    {
        public AssignmentCourse()
        {
            CourseTypeName = "Assignment Course";
        }
    }

    class Course<T> where T : CourseType
    {
        //Attributes
        public string Name { get; set; }
        public int Price { get; set; }
        public T CourseType { get; set; }

        public Course(string name, int price, T courseType)
        {
            Name = name;
            Price = price;
            CourseType = courseType;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine("Course Name: " + Name + ", Price: " + Price + ", Type: " + CourseType.CourseTypeName);
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            //create course instances
            Course<ExamCourse> mathCourse = new Course<ExamCourse>("Science", 200, new ExamCourse());
            Course<AssignmentCourse> historyCourse = new Course<AssignmentCourse>("History", 150, new AssignmentCourse());

            // Display course information
            mathCourse.DisplayCourseInfo();
            historyCourse.DisplayCourseInfo();

            Console.WriteLine("\nUsing polymorphism with list:");

            //using a non-generic approach to store different course types
            List<object> courses = new List<object>
            {
                mathCourse,
                historyCourse
            };

            foreach (var course in courses)
            {
                ((dynamic)course).DisplayCourseInfo();
            }
        }
    }
}
