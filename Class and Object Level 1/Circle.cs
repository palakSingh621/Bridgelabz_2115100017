using System;

namespace Object_and_Classes
{
    internal class Circle
    {
        private double radius;
        //Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        //Method to Calculate the area of the circle
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        //Method to Calculate the circumference of the circle
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        //Method to Display the result
        public void Display()
        {
            Console.WriteLine($"Circle with radius: {radius}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Circumference: {CalculateCircumference():F2}");
        }

        static void Main(String[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(r);
            circle.Display();
        }
    }
}
