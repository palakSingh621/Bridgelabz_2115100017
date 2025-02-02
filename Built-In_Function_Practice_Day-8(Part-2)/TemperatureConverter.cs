using System;
class TemperatureConverter
{
    public static void Main(String[] args)
    {
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());
		// Taking choice input from the user
        Console.Write("Convert to (C)elsius or (F)ahrenheit? ");
        char choice = Convert.ToChar(Console.ReadLine());
		choice=char.ToUpper(choice);
        if (choice == 'C')
        {
            Console.WriteLine("Converted Temperature: "+FahrenheitToCelsius(temperature)+"°C");
        }
        else if (choice == 'F')
        {
            Console.WriteLine("Converted Temperature: "+CelsiusToFahrenheit(temperature)+"°F");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
	// Method to convert temperature from Fahrenheit To Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
	// Method to Convert Temperature from Celsius To Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}