using System;
class Grades
{
	public static void Main(String[] args)
	{
		Console.Write("Enter physics marks: ");
		int physics = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter chemistry marks: ");
		int chemistry = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter maths marks:"); 
		int maths = Convert.ToInt32(Console.ReadLine());
		int average = (physics + chemistry + maths) / 3;
		if (average >= 80)
		{
			Console.WriteLine("Level 4, above agency normalized standards");
		}
		else if (average >= 70 && average <= 79)
		{
			Console.WriteLine("Level 3, at agency normalized standards");
		}
		else if (average >=60 && average <=69)
		{
			Console.WriteLine("Level 2, below but approching agency");
		}
		else if(average >=50 && average <=59)
		{
			Console.WriteLine("Level 1, well below agency normalized standards");
		}
		else if (average >=40 && average <=49)
		{
			Console.WriteLine("Level 1-, too below agency standards");
		}
		else{
			Console.WriteLine("Remedial standards");
		}
	}
}