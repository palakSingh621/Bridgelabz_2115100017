using System;
public class PointCalculator
{
    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double xDiff = x2 - x1;
        double yDiff = y2 - y1;
        
        // Calculate distance using Euclidean formula
        double distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        return distance;
    }
    
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        double[] result = new double[2];
        
        // Calculate slope (m)
        double slope = (y2 - y1) / (x2 - x1);
        
        // Calculate y-intercept (b)
        double yIntercept = y1 - (slope * x1);
        
        // Store slope and y-intercept in array
        result[0] = slope;
        result[1] = yIntercept;
        
        return result;
    }
    
    public static void Main()
    {
        try
        {
            // Get input for first point
            Console.WriteLine("Enter coordinates for first point:");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());
            
            // Get input for second point
            Console.WriteLine("\nEnter coordinates for second point:");
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());
            
            // Calculate and display distance
            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine("\nEuclidean Distance: {0:F2} units", distance);
            
            // Check if points are vertically aligned (undefined slope)
            if (x1 == x2)
            {
                Console.WriteLine("The line is vertical with equation: x = " + x1);
            }
            else
            {
                // Calculate and display line equation
                double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
                double slope = lineEquation[0];
                double yIntercept = lineEquation[1];
                
                Console.WriteLine("\nLine Equation:");
                Console.WriteLine("Slope (m): {0:F2}", slope);
                Console.WriteLine("Y-intercept (b): {0:F2}", yIntercept);
                Console.WriteLine("Equation: y = {0:F2}x + {1:F2}", slope, yIntercept);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot calculate slope for vertical line.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}