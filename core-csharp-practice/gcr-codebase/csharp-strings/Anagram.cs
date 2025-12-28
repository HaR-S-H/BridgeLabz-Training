using System;

class Anagram
{
    static bool AreAnagrams(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        char[] a = s1.ToCharArray();
        char[] b = s2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        if (AreAnagrams(s1, s2))
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}
