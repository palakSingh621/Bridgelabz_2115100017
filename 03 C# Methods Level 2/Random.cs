using System;
class RandomNumbers
{
    // Method to generate an array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }
        return numbers;
    }
    // Method to find the average, minimum, and maximum values of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
        }
        double average = (double)sum / numbers.Length;
        return new double[] { average, min, max };
    }
    public static void Main(string[] args)
    {
        RandomNumbers obj= new RandomNumbers();
        // Generate an array of 5 random 4-digit numbers
        int[] randomNumbers = obj.Generate4DigitRandomArray(5);
		Console.WriteLine("Generated Numbers: ");
		foreach(int v in randomNumbers){
        Console.WriteLine(v+", ");
		}
        double[] results = obj.FindAverageMinMax(randomNumbers);
        Console.WriteLine("Average: "+results[0]);
        Console.WriteLine("Minimum: "+results[1]);
        Console.WriteLine("Maximum: "+results[2]);
    }
}
