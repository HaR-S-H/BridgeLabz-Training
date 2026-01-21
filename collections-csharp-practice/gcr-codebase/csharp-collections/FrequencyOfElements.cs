using System;
using System.Collections.Generic;

class FrequencyDemo
{
    static void Main()
    {
        List<string> list = new List<string>
        { "apple", "banana", "apple", "orange" };

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string item in list)
        {
            if (freq.ContainsKey(item))
                freq[item]++;
            else
                freq[item] = 1;
        }

        foreach (var kv in freq)
            Console.WriteLine(kv.Key + " : " + kv.Value);
    }
}
