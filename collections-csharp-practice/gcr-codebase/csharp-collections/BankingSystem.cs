using System;
using System.Collections.Generic;

class BankingSystem
{
    static void Main()
    {
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        SortedDictionary<double, int> sortedByBalance = new SortedDictionary<double, int>();
        Queue<int> withdrawals = new Queue<int>();

        accounts[101] = 5000;
        accounts[102] = 15000;
        accounts[103] = 8000;

        foreach (var acc in accounts)
            sortedByBalance[acc.Value] = acc.Key;

        withdrawals.Enqueue(101);
        withdrawals.Enqueue(103);

        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var acc in sortedByBalance)
            Console.WriteLine("Account " + acc.Value + " : " + acc.Key);

        Console.WriteLine("\nProcessing Withdrawals:");
        while (withdrawals.Count > 0)
        {
            int accNo = withdrawals.Dequeue();
            Console.WriteLine("Processing withdrawal for Account: " + accNo);
        }
    }
}
