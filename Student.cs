using System;
namespace Constructors_Assignment
{
    internal class Student
    {
        public int rollNumber;
        protected string name;
        private double CGPA;
        //Constructor
        public Student(int rollNumber, string name, double CGPA)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.CGPA = CGPA;
        }
        //Updating CGPA of a student
        public void updateCGPA()
        {
            Console.WriteLine("Enter the new CGPA");
            CGPA = Convert.ToDouble(Console.ReadLine());
        }
        //Displaying student details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Roll number: " + rollNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("CGPA: " + CGPA);
        }
    }
    class PostgraduateStudent : Student
    {
        public PostgraduateStudent(int rollNumber, string name, double CGPA) : base(rollNumber, name, CGPA)
        {

        }
        //Modifying the protected member directly in a subclass to show the functionality of protected member
        public void UpdateName()
        {
            Console.WriteLine("Enter the new name");
            name = Console.ReadLine();
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // accessing base class method for over riding
        }
    }
    class program11
    {
        public static void Main(String[] args)
        {
            Student student1 = new Student(2115100017, "Palak", 8.0);
            student1.DisplayDetails();
            Console.WriteLine();
            student1.updateCGPA();
            student1.DisplayDetails();
            Console.WriteLine();
            PostgraduateStudent pg1 = new PostgraduateStudent(2115100012, "Divyanshi", 7.8);
            pg1.DisplayDetails();
            pg1.UpdateName();
            pg1.DisplayDetails();
        }
    }
}
