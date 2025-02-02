using System;
class Handshake
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int maximumHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine("The maximum number of handshakes among "+numberOfStudents+" students is "+maximumHandshakes+".");
    }
}
