using System;
using System.Collections.Generic;

class RodCutting
{
    // Function to calculate maximum revenue using Dynamic Programming
    static int MaxRevenue(int[] price, int n, out List<int> cuts)
    {
        int[] dp = new int[n + 1];
        int[] cutAt = new int[n + 1];

        dp[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            int maxVal = int.MinValue;

            for (int j = 1; j <= i; j++)
            {
                if (price[j] + dp[i - j] > maxVal)
                {
                    maxVal = price[j] + dp[i - j];
                    cutAt[i] = j;
                }
            }
            dp[i] = maxVal;
        }

        // Reconstruct cuts
        cuts = new List<int>();
        int length = n;
        while (length > 0)
        {
            cuts.Add(cutAt[length]);
            length -= cutAt[length];
        }

        return dp[n];
    }

    // Scenario C: Non-optimized revenue
    static int NoOptimization(int[] price, int n)
    {
        // Case: Sell whole rod directly
        return price[n];
    }

    static int RandomCuts(int[] price)
    {
        // Example: Always cut in half (4 + 4)
        return price[4] + price[4];
    }

    static int SmallCuts(int[] price)
    {
        // Example: Cut into all 1-length pieces
        return price[1] * 8;
    }

    static void PrintCuts(List<int> cuts)
    {
        Console.Write("Best Cut Strategy: ");
        foreach (int c in cuts)
            Console.Write(c + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        int rodLength = 8;

        // =============================
        // Scenario A: Original Price Chart
        // =============================
        Console.WriteLine("SCENARIO A: Optimized Revenue\n");

        int[] priceA = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };

        List<int> cutsA;
        int maxRevenueA = MaxRevenue(priceA, rodLength, out cutsA);

        Console.WriteLine("Maximum Revenue: ₹" + maxRevenueA);
        PrintCuts(cutsA);

        // =============================
        // Scenario B: Custom Length Order
        // =============================
        Console.WriteLine("\nSCENARIO B: With Custom Length Order\n");

        int[] priceB = { 0, 1, 5, 12, 9, 10, 17, 17, 20 }; // Length 3 = ₹12 (premium)

        List<int> cutsB;
        int maxRevenueB = MaxRevenue(priceB, rodLength, out cutsB);

        Console.WriteLine("Maximum Revenue with Custom Order: ₹" + maxRevenueB);
        PrintCuts(cutsB);

        // =============================
        // Scenario C: Non-Optimized Strategies
        // =============================
        Console.WriteLine("\nSCENARIO C: Without Optimization\n");

        int noCut = NoOptimization(priceA, rodLength);
        int random = RandomCuts(priceA);
        int small = SmallCuts(priceA);

        Console.WriteLine("Sell Whole Rod: ₹" + noCut);
        Console.WriteLine("Random Cuts (4+4): ₹" + random);
        Console.WriteLine("All Small Cuts (1x8): ₹" + small);

        // =============================
        // Comparison Summary
        // =============================
        Console.WriteLine("\nREVENUE COMPARISON\n");
        Console.WriteLine("Optimized (Scenario A): ₹" + maxRevenueA);
        Console.WriteLine("With Custom Order (Scenario B): ₹" + maxRevenueB);
        Console.WriteLine("No Optimization: ₹" + noCut);
        Console.WriteLine("Random Strategy: ₹" + random);
        Console.WriteLine("Worst Strategy: ₹" + small);
    }
}
