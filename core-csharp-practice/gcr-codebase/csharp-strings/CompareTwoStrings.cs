using System;

class CompareTwoStrings
{
    static int CompareStrings(string s1, string s2)
    {
        int len = s1.Length < s2.Length ? s1.Length : s2.Length;

        for (int i = 0; i < len; i++)
        {
            if (s1[i] != s2[i])
                return s1[i] - s2[i];
        }

        return s1.Length - s2.Length;
    }

    static void Main()
    {
        string s1 = "apple";
        string s2 = "banana";

        int result = CompareStrings(s1, s2);

        if (result < 0)
            Console.WriteLine("\"apple\" comes before \"banana\"");
        else
            Console.WriteLine("\"banana\" comes before \"apple\"");
    }
}
