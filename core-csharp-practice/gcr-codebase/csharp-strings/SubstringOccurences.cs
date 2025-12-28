using System;

class SubstringOccurences
{
    static int CountSubstring(string text, string sub)
    {
        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            if (text.Substring(i, sub.Length) == sub)
                count++;
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter main string: ");
        string str = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        Console.WriteLine("Occurrences: " + CountSubstring(str, sub));
    }
}
