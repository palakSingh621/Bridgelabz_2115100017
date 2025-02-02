using System;
class FootballTeam
{
    // Method to generate random heights for players
    public int[] GeneratePlayerHeights(int size)
    {
        int[] heights = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            // Generate random height between 150 and 250 cm
            heights[i] = random.Next(150, 251);
        }
        return heights;
    }
    // Method to calculate the sum of all heights
    public int CalculateSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }
    // Method to calculate the mean height
    public double CalculateMean(int[] heights)
    {
        int sum = CalculateSum(heights);
        return (double)sum / heights.Length;
    }
    // Method to find the shortest height
    public int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
                shortest = height;
        }
        return shortest;
    }
    // Method to find the tallest height
    public int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
                tallest = height;
        }
        return tallest;
    }
    public static void Main(string[] args)
    {
        FootballTeam team = new FootballTeam();
        // Generate random heights for 11 players
        int[] playerHeights = team.GeneratePlayerHeights(11);
		Console.WriteLine("Player Heights (in cms): ");
		foreach(int player in playerHeights)
		{
			Console.WriteLine(player);
		}
        int sum = team.CalculateSum(playerHeights);
        double mean = team.CalculateMean(playerHeights);
        int shortest = team.FindShortestHeight(playerHeights);
        int tallest = team.FindTallestHeight(playerHeights);
        Console.WriteLine("Sum of Heights: "+sum+" cm");
        Console.WriteLine("Mean Height: "+mean+" cm");
        Console.WriteLine("Shortest Height: "+shortest+" cm");
        Console.WriteLine("Tallest Height: "+tallest+" cm");
    }
}