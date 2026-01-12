using System;

// Represents a metal rod with prices for each cut length
class MetalRod
{
    private int length;
    private int[] prices; // prices[cutLength] = price

    public MetalRod(int length, int[] prices)
    {
        this.length = length;
        this.prices = new int[length + 1]; // 1-based indexing
        for (int i = 1; i <= length; i++)
            this.prices[i] = prices[i];
    }

    public int Length { get { return length; } }

    public int GetPrice(int cutLength)
    {
        if (cutLength <= 0 || cutLength > length)
            return 0;
        return prices[cutLength];
    }
}

// Handles cutting strategy for metal rods
class MetalRodCutter
{
    private MetalRod rod;
    private int[] maxRevenue; // max revenue for each sub-length
    private int[] cutAt;      // optimal cut at each length

    public MetalRodCutter(MetalRod rod)
    {
        this.rod = rod;
        maxRevenue = new int[rod.Length + 1];
        cutAt = new int[rod.Length + 1];
    }

    public void CalculateMaxRevenue()
    {
        maxRevenue[0] = 0;

        for (int i = 1; i <= rod.Length; i++)
        {
            int maxVal = int.MinValue;
            int bestCut = 0;
            for (int j = 1; j <= i; j++)
            {
                int revenue = rod.GetPrice(j) + maxRevenue[i - j];
                if (revenue > maxVal)
                {
                    maxVal = revenue;
                    bestCut = j;
                }
            }
            maxRevenue[i] = maxVal;
            cutAt[i] = bestCut;
        }
    }

    public int GetMaxRevenue()
    {
        return maxRevenue[rod.Length];
    }

    public void PrintOptimalCuts()
    {
        Console.Write("Optimal cuts: ");
        int n = rod.Length;
        while (n > 0)
        {
            Console.Write(cutAt[n] + " ");
            n -= cutAt[n];
        }
        Console.WriteLine();
    }

    public void AddCustomOrder(int customLength, int customPrice)
    {
        if (customLength > rod.Length)
        {
            Console.WriteLine("Custom order exceeds rod length, ignored.");
            return;
        }

        int[] newPrices = new int[rod.Length + 1];
        for (int i = 1; i <= rod.Length; i++)
            newPrices[i] = rod.GetPrice(i);

        newPrices[customLength] = customPrice;

        rod = new MetalRod(rod.Length, newPrices);
        maxRevenue = new int[rod.Length + 1];
        cutAt = new int[rod.Length + 1];
    }
}

// Test for Story 1
class Program1
{
    static void Main(string[] args)
    {
        int rodLength = 8;
        int[] prices = new int[rodLength + 1] { 0, 1, 5, 8, 9, 10, 17, 17, 20 };

        MetalRod rod = new MetalRod(rodLength, prices);
        MetalRodCutter cutter = new MetalRodCutter(rod);

        cutter.CalculateMaxRevenue();
        Console.WriteLine("--- Metal Rod Cutting ---");
        Console.WriteLine("Maximum revenue: " + cutter.GetMaxRevenue());
        cutter.PrintOptimalCuts();

        // Add custom order
        cutter.AddCustomOrder(3, 12);
        cutter.CalculateMaxRevenue();
        Console.WriteLine("After adding custom order:");
        Console.WriteLine("Maximum revenue: " + cutter.GetMaxRevenue());
        cutter.PrintOptimalCuts();
    }
}
