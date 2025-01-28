using System;
class UnitConverter
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }
    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }
    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }
    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
    public static void Main(string[] args)
    {
		double ans;
        Console.Write("Enter kilometers to convert to miles: ");
        double km = Convert.ToDouble(Console.ReadLine());
		ans=ConvertKmToMiles(km);
        Console.WriteLine(km+" kilometers is "+ans+" miles");
		
        Console.Write("Enter miles to convert to kilometers: ");
        double miles = Convert.ToDouble(Console.ReadLine());
		ans=ConvertMilesToKm(miles);
        Console.WriteLine(miles+" miles is "+ans+" kilometers");
		
        Console.Write("Enter meters to convert to feet: ");
        double meters = Convert.ToDouble(Console.ReadLine());
		ans=ConvertMetersToFeet(meters);
        Console.WriteLine(meters+" meters is "+ans+" feet");
		
        Console.Write("Enter feet to convert to meters: ");
        double feet = Convert.ToDouble(Console.ReadLine());
		ans=ConvertFeetToMeters(feet);
        Console.WriteLine(feet+" feet is "+ans+" meters");
    }
}
