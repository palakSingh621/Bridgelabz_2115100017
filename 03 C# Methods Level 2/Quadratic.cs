using System;
class Quadratic
{
	public static double[] roots(int a, int b, int c)
	{
		double delta=Math.Pow(b,2)+4*a*c;
		if(delta > 0){
			double root1=(-b+Math.Sqrt(delta))/(2*a);
			double root2=(-b-Math.Sqrt(delta))/(2*a);
			return new double[] {root1, root2};
		}else if(delta == 0){
			double root1= -b/(2*a);
			return new double[] {root1};
		}else{
			return new double[] {};
		}
	}
	public static void Main(String[] args)
	{
		Console.Write("Enter the value of a: ");
		int a= Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the value of b: ");
		int b= Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the value of c: ");
		int c= Convert.ToInt32(Console.ReadLine());
		
		double[] arr=roots(a,b,c);
		Console.WriteLine("Roots of Equation: ");
		foreach(double v in arr){
			Console.WriteLine(v+", ");
		}
	}
}