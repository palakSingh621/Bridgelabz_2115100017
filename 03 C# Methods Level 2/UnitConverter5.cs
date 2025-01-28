using System;
class UnitConverter5
{
    // Method to convert yards to feet
    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }
    // Method to convert feet to yards
    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }
    // Method to convert meters to inches
    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }
    // Method to convert inches to meters
    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }
    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter yards to convert to feet: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(yards+" yards is "+ConvertYardsToFeet(yards)+" feet");

        Console.Write("Enter feet to convert to yards: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(feet+" feet is "+ConvertFeetToYards(feet)+" yards");

        Console.Write("Enter meters to convert to inches: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(meters+" meters is "+ConvertMetersToInches(meters)+" inches");

        Console.Write("Enter inches to convert to meters: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(inches+" inches is "+ConvertInchesToMeters(inches)+" meters");

        Console.Write("Enter inches to convert to centimeters: ");
        double inchesToCm = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(inchesToCm+" inches is "+ConvertInchesToCentimeters(inchesToCm)+" cm");
    }
}
