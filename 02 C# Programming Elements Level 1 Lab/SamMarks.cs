using System;

class SamMarks
{
	public static void Main(String [] args)
	{
		int mathsMark = 94;
		int physicsMark = 95;
		int chemistryMark = 96;
		int totalMarks = 100;
		double averageMarks = (mathsMark + physicsMark + chemistryMark)/3.0;
		Console.WriteLine("Sam's average mark in PCM is "+averageMarks);
	}
}