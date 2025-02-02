using System;
namespace Constructors_Assignment
{
    internal class Circle
    {
        //Attribute
        private double radius;
        //Constructors
        public Circle(double radius)
        {
            this.radius = radius;
        }
        //Constructor chaining
        public Circle() : this(1) { }
        //Calculating area
        public double Area()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        //Calculating circumference
        public double Circumference()
        {
            double c = 2 * Math.PI * radius;
            return c;
        }
        //Displaying result
        public void DisplayResult()
        {
            Console.WriteLine("The area of the circle with the radius " + radius + " is: " + Area());
            Console.WriteLine("The circumference of the circle with the radius " + radius + " is: " + Circumference());
        }
        static void Main(String[] args)
        {
            Circle circle1 = new Circle(5.6);
            Circle circle2 = new Circle();
            circle1.DisplayResult();
            Console.WriteLine(" ");
            circle2.DisplayResult();

        }
    }

}
