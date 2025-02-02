using System;
class Handshake
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int maximumHandshakes = handshakes(numberOfStudents);
        Console.WriteLine("The maximum number of handshakes among "+numberOfStudents+" students is "+maximumHandshakes+".");
    }
	public static int handshakes(int numberOfStudents)
	{
		int maximumHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
		return maximumHandshakes;
	}
}