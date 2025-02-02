using System;
class EmployeeBonusCalculator
{
    private const int NUMBER_OF_EMPLOYEES = 10;
    private const double LONG_SERVICE_BONUS_RATE = 0.05; // 5%
    private const double SHORT_SERVICE_BONUS_RATE = 0.02; // 2%
    private const int SERVICE_YEAR_THRESHOLD = 5;

    public static double[,] GenerateEmployeeData()
    {
        Random random = new Random();
        double[,] employeeData = new double[NUMBER_OF_EMPLOYEES, 2];

        for (int i = 0; i < NUMBER_OF_EMPLOYEES; i++)
        {
            // Generate random 5-digit salary (10000-99999)
            employeeData[i, 0] = random.Next(10000, 100000);
            
            // Generate random years of service (0-10)
            employeeData[i, 1] = random.Next(0, 11);
        }

        return employeeData;
    }

    public static double[,] CalculateNewSalaryAndBonus(double[,] employeeData)
    {
        double[,] newData = new double[NUMBER_OF_EMPLOYEES, 2]; // [bonus, new salary]

        for (int i = 0; i < NUMBER_OF_EMPLOYEES; i++)
        {
            double currentSalary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            
            // Calculate bonus based on years of service
            double bonusRate = yearsOfService > SERVICE_YEAR_THRESHOLD ? 
                             LONG_SERVICE_BONUS_RATE : SHORT_SERVICE_BONUS_RATE;
            
            double bonus = currentSalary * bonusRate;
            double newSalary = currentSalary + bonus;
            
            newData[i, 0] = bonus;
            newData[i, 1] = newSalary;
        }

        return newData;
    }

    public static void DisplayEmployeeData(double[,] employeeData, double[,] bonusData)
    {
        Console.WriteLine("\n{0,-5} {1,-12} {2,-10} {3,-12} {4,-12}", 
            "EmpID", "Old Salary", "Years", "Bonus", "New Salary");
        Console.WriteLine(new string('-', 55));

        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        for (int i = 0; i < NUMBER_OF_EMPLOYEES; i++)
        {
            Console.WriteLine("{0,-5} {1,-12:C} {2,-10:F1} {3,-12:C} {4,-12:C}",
                i + 1,
                employeeData[i, 0],
                employeeData[i, 1],
                bonusData[i, 0],
                bonusData[i, 1]);

            totalOldSalary += employeeData[i, 0];
            totalBonus += bonusData[i, 0];
            totalNewSalary += bonusData[i, 1];
        }

        Console.WriteLine(new string('-', 55));
        Console.WriteLine("\nSummary:");
        Console.WriteLine("Total Old Salary: {0:C}", totalOldSalary);
        Console.WriteLine("Total Bonus Amount: {0:C}", totalBonus);
        Console.WriteLine("Total New Salary: {0:C}", totalNewSalary);
        Console.WriteLine("Percentage Increase: {0:F2}%", 
            (totalNewSalary - totalOldSalary) * 100 / totalOldSalary);
    }

    public static void Main()
    {
        Console.WriteLine("Zara Employee Bonus Calculator\n");
        
        // Generate random employee data
        double[,] employeeData = GenerateEmployeeData();
        
        // Calculate bonuses and new salaries
        double[,] bonusData = CalculateNewSalaryAndBonus(employeeData);
        
        // Display results in tabular format
        DisplayEmployeeData(employeeData, bonusData);
    }
}