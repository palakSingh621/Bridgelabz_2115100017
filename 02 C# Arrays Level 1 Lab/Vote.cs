using System;
class Vote
{
	public static void Main(String[] args)
	{
		int [] ages = new int [10];
		for(int i= 0;i<10;i++){
			Console.Write("Enter the age for student "+(i+1)+": ");
			int age = Convert.ToInt32(Console.ReadLine());
			ages[i] = age;
		}
		for(int j=0;j<10;j++){
			if(ages[j] < 0)
			{
				Console.WriteLine("Please enter an invalid age");
			}
			else if(ages[j] >= 18){
				Console.WriteLine("The student with the age "+ages[j]+" can vote");
			}
			else{
				Console.WriteLine("The student with the age "+ages[j]+" cannot vote");
			}
		}
	}
}
