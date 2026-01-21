using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>
        {
            {"A",1},{"B",2},{"C",1}
        };

        Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();

        foreach (var kv in map)
        {
            if (!result.ContainsKey(kv.Value))
                result[kv.Value] = new List<string>();

            result[kv.Value].Add(kv.Key);
        }

        foreach (var kv in result)
        {
            Console.Write(kv.Key + " -> ");
            foreach (var v in kv.Value)
                Console.Write(v + " ");
            Console.WriteLine();
        }
    }
}
