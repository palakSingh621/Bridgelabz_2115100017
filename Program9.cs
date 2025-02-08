using System;
namespace Assignment_12_Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void DisplayRole()
        {
            Console.WriteLine("This is a person in the school system.");
        }
    }

    // Derived class Teacher
    class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }
        public override void DisplayRole()
        {
            Console.WriteLine($"This is a Teacher. Subject: {Subject}");
        }
    }
    // Derived class Student
    class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"This is a Student. Grade: {Grade}");
        }
    }
    // Derived class Staff
    class Staff : Person
    {
        public string Position { get; set; }

        public Staff(string name, int age, string position)
            : base(name, age)
        {
            Position = position;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"This is a Staff member. Position: {Position}");
        }
    }
    internal class Program9
    {
        static void Main()
        {
            Person teacher = new Teacher("Mr.Prabhat", 40, "C#");
            Person student = new Student("Palak", 16, 10);
            Person staff = new Staff("Dr. M. Srivastava", 45, "Administrator");
            teacher.DisplayRole();
            student.DisplayRole();
            staff.DisplayRole();
        }
    }
}
