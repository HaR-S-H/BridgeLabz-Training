using System;
using System.Collections.Generic;

class Policy
{
    public int PolicyNo;
    public string Coverage;
    public DateTime ExpiryDate;

    public override bool Equals(object obj)
        => obj is Policy p && PolicyNo == p.PolicyNo;

    public override int GetHashCode()
        => PolicyNo.GetHashCode();

    public override string ToString()
        => $"{PolicyNo} | {Coverage} | {ExpiryDate:d}";
}

class InsurancePolicySystem
{
    static void Main()
    {
        // HashSet → Unique policies
        HashSet<Policy> uniquePolicies = new HashSet<Policy>();

        // LinkedHashSet equivalent → preserve insertion order
        List<Policy> insertionOrder = new List<Policy>();

        // TreeSet equivalent → sorted by expiry
        SortedSet<Policy> sortedByExpiry = new SortedSet<Policy>(
            Comparer<Policy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate))
        );

        Policy p1 = new Policy { PolicyNo = 101, Coverage = "Health", ExpiryDate = DateTime.Now.AddDays(10) };
        Policy p2 = new Policy { PolicyNo = 102, Coverage = "Life", ExpiryDate = DateTime.Now.AddDays(40) };
        Policy p3 = new Policy { PolicyNo = 101, Coverage = "Health", ExpiryDate = DateTime.Now.AddDays(10) };

        AddPolicy(p1, uniquePolicies, insertionOrder, sortedByExpiry);
        AddPolicy(p2, uniquePolicies, insertionOrder, sortedByExpiry);
        AddPolicy(p3, uniquePolicies, insertionOrder, sortedByExpiry); // duplicate

        Console.WriteLine("\nAll Unique Policies:");
        foreach (var p in uniquePolicies)
            Console.WriteLine(p);

        Console.WriteLine("\nPolicies Expiring in 30 Days:");
        foreach (var p in sortedByExpiry)
            if ((p.ExpiryDate - DateTime.Now).Days <= 30)
                Console.WriteLine(p);

        Console.WriteLine("\nHealth Coverage Policies:");
        foreach (var p in uniquePolicies)
            if (p.Coverage == "Health")
                Console.WriteLine(p);
    }

    static void AddPolicy(Policy p, HashSet<Policy> set, List<Policy> list, SortedSet<Policy> sorted)
    {
        if (set.Add(p))
        {
            list.Add(p);
            sorted.Add(p);
        }
        else
        {
            Console.WriteLine($"Duplicate Policy Found: {p.PolicyNo}");
        }
    }
}
