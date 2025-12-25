using System;

class NumberChecker
{
    static void Main()
    {
        int num = 153;
        int[] digits = GetDigits(num);

        Console.WriteLine("Duck Number: " + IsDuck(digits));
        Console.WriteLine("Armstrong: " + IsArmstrong(num, digits));

        int[] max = FindLargestSecond(digits);
        int[] min = FindSmallestSecond(digits);

        Console.WriteLine("Largest: " + max[0] + " Second: " + max[1]);
        Console.WriteLine("Smallest: " + min[0] + " Second: " + min[1]);
    }

    static int[] GetDigits(int n)
    {
        int temp = n, count = 0;
        while (temp > 0) { count++; temp /= 10; }

        int[] d = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            d[i] = n % 10;
            n /= 10;
        }
        return d;
    }

    static bool IsDuck(int[] d)
    {
        foreach (int x in d)
            if (x == 0) return true;
        return false;
    }

    static bool IsArmstrong(int n, int[] d)
    {
        int sum = 0;
        foreach (int x in d)
            sum += (int)Math.Pow(x, d.Length);
        return sum == n;
    }

    static int[] FindLargestSecond(int[] d)
    {
        int max = int.MinValue, second = int.MinValue;
        foreach (int x in d)
        {
            if (x > max) { second = max; max = x; }
            else if (x > second && x != max) second = x;
        }
        return new int[] { max, second };
    }

    static int[] FindSmallestSecond(int[] d)
    {
        int min = int.MaxValue, second = int.MaxValue;
        foreach (int x in d)
        {
            if (x < min) { second = min; min = x; }
            else if (x < second && x != min) second = x;
        }
        return new int[] { min, second };
    }
}
