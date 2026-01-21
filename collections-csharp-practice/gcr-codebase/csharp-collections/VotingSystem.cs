using System;
using System.Collections.Generic;
using System.Collections.Specialized;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
        OrderedDictionary voteOrder = new OrderedDictionary();

        CastVote("Alice", votes, voteOrder);
        CastVote("Bob", votes, voteOrder);
        CastVote("Alice", votes, voteOrder);

        foreach (var v in votes)
            sortedVotes[v.Key] = v.Value;

        Console.WriteLine("\nVotes (Sorted):");
        foreach (var v in sortedVotes)
            Console.WriteLine(v.Key + " : " + v.Value);

        Console.WriteLine("\nVote Order:");
        foreach (var key in voteOrder.Keys)
            Console.WriteLine(key);
    }

    static void CastVote(string candidate,
                         Dictionary<string, int> votes,
                         OrderedDictionary order)
    {
        if (!votes.ContainsKey(candidate))
        {
            votes[candidate] = 0;
            order.Add(candidate, null);
        }
        votes[candidate]++;
    }
}
