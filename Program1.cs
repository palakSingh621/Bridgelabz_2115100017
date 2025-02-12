using System;
namespace Assignment_14_LinkedList
{
    //Class to create a Node for Student List
    public class Student
    {
        public int rollNo;
        public string name;
        public char grade;
        public int age;
        public Student Next;
        public Student(int rollNo, string name, int age, char grade)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.age = age;
            this.grade = grade;
            Next = null;
        }
    }
    class StudentLinkedList
    {
        public Student head;
        //Method to Add student at the beginning of the list
        public void AddStudentAtFront(int rollNumber, string name, int age, char grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            newStudent.Next = head;
            head = newStudent;
        }
        //Methos to add the student at the end of the list
        public void AddStudentAtLast(int rollNumber, string name, int age, char grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (head == null)
            {
                head = newStudent;
                return;
            }
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
        }
        //Method to add the student at the given position of the list
        public void AddStudentAtPosition(int rollNumber, string name, int age, char grade, int position)
        {
            int count = 1;
            Student newStudent = new Student(rollNumber, name, age, grade);
            Student temp = head;
            while (count < position)
            {
                temp = temp.Next;
                count++;
            }
            Student prev = temp;
            temp = temp.Next;
            newStudent.Next = temp;
            prev.Next = newStudent;
        }
        //Method to delete the student by rollNumber from the list
        public void DeleteStudent(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Student temp = head;
            while (temp.Next.rollNo != rollNumber)
            {
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                Console.WriteLine("Student not fount");
            }
            temp.Next = temp.Next.Next;
        }
        // Method to search the student by rollNumber in the list
        public Student SearchStudent(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return null;
            }
            Student temp = head;
            if (temp != null && temp.rollNo != rollNumber)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Student not found");
                return null;
            }
            return temp;
        }
        //Method to dispaly the details of single student
        public void DisplayStudentDetails(Student student)
        {
            Console.WriteLine($"Student Name: {student.name}");
            Console.WriteLine($"Roll Number: {student.rollNo}");
            Console.WriteLine($"Age: {student.age}");
            Console.WriteLine($"Grade: {student.grade}");
            Console.WriteLine();
        }
        // Method to display the List of students
        public void DisplayStudentList()
        {
            if (head == null)
            {
                Console.WriteLine("Student list is empty");
                return;
            }
            Student temp = head;
            while (temp != null)
            {
                DisplayStudentDetails(temp);
                temp = temp.Next;
            }
        }
        //Method to update the grade of teh student by roll number
        public void UpdateStudentGrade(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Student temp = head;
            while (temp != null && temp.rollNo != rollNumber)
            {
                temp = temp.Next;
            }
            Console.WriteLine("Enter the Updated Grade: ");
            char g = Convert.ToChar(Console.ReadLine());
            temp.grade = g;
        }
    }
    internal class Program1
    {
        static void Main(string[] args)
        {
            StudentLinkedList studentList = new StudentLinkedList();
            studentList.AddStudentAtLast(101, "Alice", 20, 'A');
            studentList.AddStudentAtFront(102, "Bob", 21, 'B');
            studentList.AddStudentAtFront(100, "Charlie", 22, 'C');
            studentList.AddStudentAtPosition(103, "David", 23, 'A', 2);
            studentList.DisplayStudentList();
            Console.WriteLine("\nSearching for student with Roll No 102:");
            studentList.DisplayStudentDetails(studentList.SearchStudent(102));
            Console.WriteLine("\nUpdating grade for Roll No 102:");
            studentList.UpdateStudentGrade(102);
            studentList.DisplayStudentList();
            Console.WriteLine("\nDeleting student with Roll No 101:");
            studentList.DeleteStudent(101);
            studentList.DisplayStudentList();
        }
    }
}
