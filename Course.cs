using System;
namespace Constructors_Assignment
{
    internal class Course
    {
        //Attributes
        private string courseName;
        private int duration;
        private double fee;
        private static string instituteName = "Goals Classes";
        //Constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        //Updating the instituteName
        public static void UpdateInstituteName()
        {
            Console.WriteLine("Enter the new Institute name ");
            string newInstituteName = Console.ReadLine();
            instituteName = newInstituteName;
        }
        //Displaying course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine("The name of the course: " + courseName);
            Console.WriteLine("The duration of the course: " + duration + " months ");
            Console.WriteLine("The fee of the course: " + fee);
            Console.WriteLine("The name of the institute is: " + instituteName);
        }
        static void Main(String[] args)
        {
            Course course1 = new Course("Machine Learning", 6, 10000);
            course1.DisplayCourseDetails();
            Console.WriteLine(" ");
            Course course2 = new Course("AI", 6, 10000);
            UpdateInstituteName();
            Console.WriteLine(" ");
            course1.DisplayCourseDetails();
            Console.WriteLine(" ");
            course2.DisplayCourseDetails();
        }
    }
}
