using System;
class CollinearityChecker
{
    public static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Handle vertical lines first (undefined slope)
        if (x1 == x2 && x2 == x3)
            return true;

        try
        {
            // Calculate slopes
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            // Compare slopes with small tolerance for floating-point comparison
            const double tolerance = 0.0000001;
            return Math.Abs(slopeAB - slopeBC) < tolerance && 
                   Math.Abs(slopeBC - slopeAC) < tolerance;
        }
        catch (DivideByZeroException)
        {
            // If we get here, points are not all vertical but some are
            return false;
        }
    }

    public static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate area using the formula from the image
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        
        // Points are collinear if area is zero (using small tolerance)
        const double tolerance = 0.0000001;
        return Math.Abs(area) < tolerance;
    }

    public static void Main()
    {
        try
        {
            // Get input for first point
            Console.WriteLine("Enter coordinates for first point (A):");
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            // Get input for second point
            Console.WriteLine("\nEnter coordinates for second point (B):");
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            // Get input for third point
            Console.WriteLine("\nEnter coordinates for third point (C):");
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            // Check collinearity using both methods
            bool collinearBySlope = AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
            bool collinearByArea = AreCollinearByArea(x1, y1, x2, y2, x3, y3);

            // Display results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Using Slope Method: Points are " + 
                            (collinearBySlope ? "collinear" : "not collinear"));
            Console.WriteLine("Using Area Method: Points are " + 
                            (collinearByArea ? "collinear" : "not collinear"));

            // Show calculations
            Console.WriteLine("\nCalculations:");
            if (!collinearByArea)
            {
                double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
                Console.WriteLine("Area = " + Math.Abs(area));
            }
            else
            {
                Console.WriteLine("Area = 0 (points are collinear)");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}