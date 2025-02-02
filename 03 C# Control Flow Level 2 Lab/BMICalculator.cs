using System;
    class BMICalculator
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your weight in kilograms:");
            double userWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height in centimeters:");
            double userHeightCm = double.Parse(Console.ReadLine());

            // Convert height from cm to meters
            double userHeightM = userHeightCm / 100;

            // Calculate BMI
            double calculatedBMI = userWeight / (userHeightM * userHeightM);

            // Determine weight classification
            string classification;
            if (calculatedBMI < 18.5)
            {
                classification = "Underweight";
            }
            else if (calculatedBMI >= 18.5 && calculatedBMI < 24.9)
            {
                classification = "Normal";
            }
            else if (calculatedBMI >= 25 && calculatedBMI < 29.9)
            {
                classification = "Overweight";
            }
            else
            {
                classification = "Obese";
            }

            // Display BMI and classification
            Console.WriteLine("Your BMI is " + calculatedBMI.ToString("F2") + ".");
            Console.WriteLine("Weight classification: " + classification + ".");
        }
    }
}
