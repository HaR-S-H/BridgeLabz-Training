using System;

class ReverseString
{
    static string ReverseString(string text)
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

        string result = ReverseString(s);
        Console.WriteLine("Reversed String: " + result);
    }
}
