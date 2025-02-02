using System;
class Vote
{
    // Method to check if a student can vote
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }
        return age >= 18;
    }
    public static void Main(String[] args)
    {
		// Array to store ages of 10 students
        int[] studentAges = new int[10]; 
        Console.WriteLine("Enter the ages of 10 students: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Student "+(i + 1)+" Age: ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }
        // Loop through the array and check voting eligibility
        for (int i = 0; i < 10; i++)
        {
            bool canVote = CanStudentVote(studentAges[i]);
            if (studentAges[i] < 0)
            {
                Console.WriteLine("Student "+(i + 1)+" Age: "+studentAges[i]+" Is an invalid age.");
            }
            else
            {
                Console.WriteLine("Student "+(i + 1)+" Age: "+studentAges[i]+" - "+(canVote ? "Can Vote" : "Cannot Vote"));
            }
        }
    }
}