using System;

class Palindrome
{
    static bool IsPalindrome(string text)
    {
        int start = 0;
        int end = text.Length - 1;

        while (start < end)
        {
            if (text[start] != text[end])
                return false;

            start++;
            end--;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        if (IsPalindrome(s))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
}
