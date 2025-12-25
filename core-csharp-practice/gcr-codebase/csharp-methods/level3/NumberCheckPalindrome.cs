using System;

class NumberCheckPalindrome
{
    static void Main()
    {
        int num = 121;
        int[] d = GetDigits(num);
        int[] rev = Reverse(d);

        Console.WriteLine("Palindrome: " + AreEqual(d, rev));
        Console.WriteLine("Duck: " + IsDuck(d));
    }

    static int[] GetDigits(int n)
    {
        string s = n.ToString();
        int[] d = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
            d[i] = s[i] - '0';
        return d;
    }

    static int[] Reverse(int[] d)
    {
        int[] r = new int[d.Length];
        for (int i = 0; i < d.Length; i++)
            r[i] = d[d.Length - 1 - i];
        return r;
    }

    static bool AreEqual(int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }

    static bool IsDuck(int[] d)
    {
        foreach (int x in d)
            if (x == 0) return true;
        return false;
    }
}
