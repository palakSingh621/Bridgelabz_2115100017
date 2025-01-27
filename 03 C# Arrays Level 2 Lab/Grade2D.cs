using System;
class Grade2D
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());
        double[,] marks = new double[numStudents, 3];
        double[] percentage = new double[numStudents];
        string[] grade = new string[numStudents];
		for (int i = 0; i < numStudents; i++)
        {
            Console.Write("Enter marks for student " + (i + 1) + ": ");
            Console.Write("Physics: ");
            marks[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chemistry: ");
            marks[i, 1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Maths: ");
            marks[i, 2] = Convert.ToDouble(Console.ReadLine());
			// Calculate the total marks and percentage
            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentage[i] = (totalMarks / 300) * 100;
			// Determine the grade based on the percentage
            if (percentage[i] >= 80)
                grade[i] = "A";
            else if (percentage[i] >= 70 && percentage[i] < 80)
                grade[i] = "B";
            else if (percentage[i] >= 60 && percentage[i] < 70)
                grade[i] = "C";
            else if (percentage[i] >= 50 && percentage[i] < 60)
                grade[i] = "D";
            else if (percentage[i] >= 40 && percentage[i] < 50)
                grade[i] = "E";
            else
                grade[i] = "R";
        }
        Console.WriteLine("\nResults:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": Physics " + marks[i, 0] + ", Chemistry " + marks[i, 1] + ", Maths " + marks[i, 2] + ", Percentage " + percentage[i] + "%, Grade " + grade[i]);
        }
    }
}
