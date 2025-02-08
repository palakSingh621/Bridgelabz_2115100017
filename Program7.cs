using System;
namespace Assignment_12_Inheritance
{
    internal class Course
    {
        //Attributes
        private string CourseName { get; set; }
        private string Duration { get; set; }
        //Constructors
        public Course(string courseName, string duration)
        {
            CourseName = courseName;
            Duration = duration;
        }
        //DisplayDetails
        public virtual void DisplayDetails()
        {
            Console.WriteLine("The name of the course " + CourseName);
            Console.WriteLine("The duration of the course is " + Duration);
        }
    }
    class OnlineCourse : Course
    {
        //Attributes
        private string Platform { get; set; }
        private bool IsRecorded { get; set; }
        //Constructor
        public OnlineCourse(string CourseName, string Duration, string platform, bool isRecorded) : base(CourseName, Duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The platfrom of the course is " + Platform);
            if (IsRecorded)
            {
                Console.WriteLine("The course is recorded");
            }
            else
            {
                Console.WriteLine("The course is not recorded!");
            }
        }
    }
    class PaidOnlineCourse : OnlineCourse
    {
        //Attributes
        private double Fee { get; set; }
        private double Discount { get; set; }
        //Constructor
        public PaidOnlineCourse(string CourseName, string Duration, string Platform, bool IsRecorded, double fee, double discount) : base(CourseName, Duration, Platform, IsRecorded)
        {
            Fee = fee;
            Discount = discount;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("The fee of the course is " + Fee);
            Console.WriteLine("The discount on the course is " + Discount);
        }
    }
    internal class program7
    {
        public static void Main(String[] args)
        {
            Course course1 = new Course("Python", "3 months");
            course1.DisplayDetails();
            OnlineCourse oc1 = new OnlineCourse("AI", "3 months", "Youtube", true);
            oc1.DisplayDetails();
            PaidOnlineCourse poc1 = new PaidOnlineCourse("C#", "2 months", "Udemy", true, 10000, 2000);
            poc1.DisplayDetails();
        }
    }
}
