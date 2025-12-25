using System;

class NumberCheckerHarshHad
{
    static void Main()
    {
        int num = 21;
        int[] digits = GetDigits(num);

        Console.WriteLine("Harshad: " + IsHarshad(num, digits));
        PrintFrequency(digits);
    }

    static int[] GetDigits(int n)
    {
        string s = n.ToString();
        int[] d = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
            d[i] = s[i] - '0';
        return d;
    }

    static bool IsHarshad(int n, int[] d)
    {
        int sum = 0;
        foreach (int x in d) sum += x;
        return n % sum == 0;
    }

    static void PrintFrequency(int[] d)
    {
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++) freq[i, 0] = i;

        foreach (int x in d) freq[x, 1]++;

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
            if (freq[i, 1] > 0)
                Console.WriteLine(i + " -> " + freq[i, 1]);
    }
}
