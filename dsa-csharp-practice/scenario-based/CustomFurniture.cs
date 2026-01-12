using System;

// Represents a wooden rod
class WoodenRod
{
    private int length;
    private int[] prices;

    public WoodenRod(int length, int[] prices)
    {
        this.length = length;
        this.prices = new int[length + 1];
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

// Handles cutting strategy for wooden rods
class FurnitureCutter
{
    private WoodenRod rod;
    private int[] maxRevenue;
    private int[] cutAt;

    public FurnitureCutter(WoodenRod rod)
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

    // Scenario: minimize waste while maximizing revenue
    public void PrintCutsWithWasteConstraint(int maxWaste)
    {
        Console.Write("Cuts with max waste " + maxWaste + ": ");
        int n = rod.Length;
        while (n > maxWaste)
        {
            Console.Write(cutAt[n] + " ");
            n -= cutAt[n];
        }
        if (n > 0)
            Console.Write(n + " "); // remaining waste
        Console.WriteLine();
    }
}

// Test for Story 2
class Program2
{
    static void Main(string[] args)
    {
        int rodLength = 12;
        int[] prices = new int[rodLength + 1] { 0, 2, 5, 7, 8, 10, 13, 17, 17, 20, 24, 30, 34 };

        WoodenRod rod = new WoodenRod(rodLength, prices);
        FurnitureCutter cutter = new FurnitureCutter(rod);

        cutter.CalculateMaxRevenue();
        Console.WriteLine("--- Custom Furniture Rod Cutting ---");
        Console.WriteLine("Maximum revenue: " + cutter.GetMaxRevenue());
        cutter.PrintOptimalCuts();

        Console.WriteLine("Cuts with max 1ft waste:");
        cutter.PrintCutsWithWasteConstraint(1);
    }
}
