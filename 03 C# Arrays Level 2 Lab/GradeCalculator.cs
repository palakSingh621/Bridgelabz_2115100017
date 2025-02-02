using System;
class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());
        double[] physics = new double[numStudents];
        double[] chemistry = new double[numStudents];
        double[] maths = new double[numStudents];
        double[] percentage = new double[numStudents];
        string[] grade = new string[numStudents];
		// Loop to collect marks for each student and calculate percentage and grade
        for (int i=0;i<numStudents; i++)
        {
            Console.WriteLine("Enter marks for student " + (i + 1) + ": ");
            Console.Write("Physics: ");
            physics[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chemistry: ");
            chemistry[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Maths: ");
            maths[i] = Convert.ToDouble(Console.ReadLine());
            double totalMarks = physics[i] + chemistry[i] + maths[i];
            percentage[i] = (totalMarks / 300) * 100;
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
        Console.Write("\nResults:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": Physics " + physics[i] + ", Chemistry " + chemistry[i] + ", Maths " + maths[i] + ", Percentage " + percentage[i] + "%, Grade " + grade[i]);
        }
    }
}