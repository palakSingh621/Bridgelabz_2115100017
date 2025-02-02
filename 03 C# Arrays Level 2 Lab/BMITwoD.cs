using System;
class BMITwoD
{
	public static void Main(string[] args)
    {
        Console.Write("Enter the number of people: ");
        int num = Convert.ToInt32(Console.ReadLine());
		// Multi-dimensional array to store weight, height, and BMI
        double[][] personData = new double[num][]; 
        string[] weightStatus = new string[num];  

        for (int i = 0; i < num; i++)
        {
			// Each person has 3 values: weight, height, and BMI
            personData[i] = new double[3];
            Console.WriteLine("Enter the weight of person " + (i + 1) + " (positive value):");
            double weight = Convert.ToDouble(Console.ReadLine());
            while (weight <= 0)
            {
                Console.WriteLine("Weight must be a positive value. Please try again.");
                weight = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter the height of person " + (i + 1) + " (positive value in meters):");
            double height = Convert.ToDouble(Console.ReadLine());
            while (height <= 0)
            {
                Console.WriteLine("Height must be a positive value");
                height = Convert.ToDouble(Console.ReadLine());
            }

            personData[i][0] = weight; 
            personData[i][1] = height; 
            personData[i][2] = weight / height; 

            //weight status
            if (personData[i][2] < 18.5)
            {
				weightStatus[i] = "Underweight";
            }
            else if (personData[i][2] < 25)
            {
                weightStatus[i] = "Normal";
            }
            else if (personData[i][2] < 30)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obese";
            }
        }
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ": Weight = " + personData[i][0] + " kg, Height = " + personData[i][1] + " m, BMI = " + personData[i][2].ToString("F2") + ", Weight Status = " + weightStatus[i]);
        }
    }
}