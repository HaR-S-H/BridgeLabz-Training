using System;
using System.Collections.Generic;

class ATMDispenser
{
    static void Main()
    {
        int amount = 880;

        Console.WriteLine("===== Scenario A: All Denominations Available =====");
        int[] denominationsA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        Dispense(amount, denominationsA);

        Console.WriteLine("\n===== Scenario B: ₹500 Note Removed =====");
        int[] denominationsB = { 200, 100, 50, 20, 10, 5, 2, 1 };
        Dispense(amount, denominationsB);

        Console.WriteLine("\n===== Scenario C: Fallback if Exact Change Not Possible =====");
        int[] denominationsC = { 200, 100, 50 };   // Limited notes
        DispenseWithFallback(amount, denominationsC);
    }

    // Scenario A & B: Normal Greedy Dispense
    static void Dispense(int amount, int[] denominations)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int originalAmount = amount;

        foreach (int note in denominations)
        {
            if (amount >= note)
            {
                int count = amount / note;
                amount = amount % note;
                result[note] = count;
            }
        }

        if (amount == 0)
        {
            PrintResult(result, originalAmount);
        }
        else
        {
            Console.WriteLine("Exact amount cannot be dispensed.");
        }
    }

    // Scenario C: Fallback Strategy
    static void DispenseWithFallback(int amount, int[] denominations)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int originalAmount = amount;
        int dispensedAmount = 0;

        foreach (int note in denominations)
        {
            if (amount >= note)
            {
                int count = amount / note;
                amount = amount % note;
                result[note] = count;
                dispensedAmount += note * count;
            }
        }

        if (amount == 0)
        {
            PrintResult(result, originalAmount);
        }
        else
        {
            Console.WriteLine("Exact amount cannot be dispensed.");
            Console.WriteLine("Fallback: Nearest lower amount dispensed = ₹" + dispensedAmount);
            PrintResult(result, dispensedAmount);
        }
    }

    // Helper Method to Print Notes
    static void PrintResult(Dictionary<int, int> result, int total)
    {
        Console.WriteLine("Dispensed Amount: ₹" + total);
        Console.WriteLine("Notes Breakdown:");

        int noteCount = 0;
        foreach (var item in result)
        {
            Console.WriteLine("₹" + item.Key + " x " + item.Value);
            noteCount += item.Value;
        }

        Console.WriteLine("Total Notes: " + noteCount);
    }
}
