using System;

class ReverseString
{
    static string DoReverseString(string text)
    {
        string rev = "";

        for (int i = text.Length - 1; i >= 0; i--)
        {
            rev = rev + text[i];
        }

        return rev;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        string result = DoReverseString(s);
        Console.WriteLine("Reversed String: " + result);
    }
}
