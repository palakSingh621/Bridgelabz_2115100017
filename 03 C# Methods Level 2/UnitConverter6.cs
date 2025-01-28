using System;
class UnitConverter6
{
    // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }
    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }
    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }
    // Method to convert liters to gallons
    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter Fahrenheit to convert to Celsius: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(fahrenheit+"°F is "+ConvertFahrenheitToCelsius(fahrenheit)+"°C");

        Console.Write("Enter Celsius to convert to Fahrenheit: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(celsius+"°C is "+ConvertCelsiusToFahrenheit(celsius)+"°F");

        Console.Write("Enter pounds to convert to kilograms: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(pounds+" lbs is "+ConvertPoundsToKilograms(pounds)+" kg");

        Console.Write("Enter kilograms to convert to pounds: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(kilograms+" kg is "+ConvertKilogramsToPounds(kilograms)+" lbs");

        Console.Write("Enter gallons to convert to liters: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(gallons+" gallons is "+ConvertGallonsToLiters(gallons)+" liters");

        Console.Write("Enter liters to convert to gallons: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(liters+" liters is "+ConvertLitersToGallons(liters)+" gallons");
    }
}