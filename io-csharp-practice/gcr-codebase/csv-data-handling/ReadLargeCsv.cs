using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int batchSize = 100;
        int total = 0;
        var batch = new List<string>();

        foreach (var line in File.ReadLines("large.csv").Skip(1))
        {
            batch.Add(line);

            if (batch.Count == batchSize)
            {
                total += batch.Count;
                Console.WriteLine($"Processed: {total}");
                batch.Clear();
            }
        }

        if (batch.Count > 0)
        {
            total += batch.Count;
            Console.WriteLine($"Processed: {total}");
        }
    }
}
