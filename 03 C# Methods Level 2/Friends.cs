using System;
class Friends
{
    public static int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
        }
        return youngestIndex;
    }
    public static int FindTallest(double[] heights)
    {
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }
        return tallestIndex;
    }
    public static void Main(String[] args)
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];
        // Taking user input for ages and heights
        Console.WriteLine("Enter the ages and heights of Amar, Akbar, and Anthony:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(friends[i]+"'s Age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write(friends[i]+"'s Height in cm: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);
        Console.WriteLine("The youngest friend is "+friends[youngestIndex]+" with age "+ages[youngestIndex]);
        Console.WriteLine("The tallest friend is "+friends[tallestIndex]+" with height "+heights[tallestIndex]+" cm.");
    }
}
