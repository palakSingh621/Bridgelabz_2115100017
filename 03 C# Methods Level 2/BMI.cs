using System;
class BMI
{
    // Method to calculate BMI and store it in the array
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0];
            double heightInCm = data[i, 1];
			// Convert cm to meters
            double heightInMeters = heightInCm / 100; 
            double bmi = weight / (heightInMeters * heightInMeters);
            data[i, 2] = bmi;
        }
    }
    // Method to determine BMI status
    public static string GetBMIStatus(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            return "Normal weight";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            return "Overweight";
        }
        else
        {
            return "Obese";
        }
    }
    public static void Main(String[] args)
    {
        double[,] teamData = new double[10,3];
        Console.WriteLine("Enter the weight in kg and height in cm of 10 team members:");
		// Take weight and height for 10 members as input
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Person "+(i + 1)+" Weight in kg: ");
            teamData[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Person "+(i + 1)+" Height in cm: ");
            teamData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }
        // Calculate BMI for each person
        CalculateBMI(teamData);
        Console.WriteLine("Team BMI Details:");
        Console.WriteLine("Person\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
        for (int i = 0; i < 10; i++)
        {
            double weight = teamData[i, 0];
            double height = teamData[i, 1];
            double bmi = teamData[i, 2];
            string status = GetBMIStatus(bmi);
            Console.WriteLine((i + 1)+"\t"+weight+"\t\t"+height+"\t\t"+bmi+"\t\t"+status);
        }
    }
}