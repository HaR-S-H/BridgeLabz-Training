using System;

class RemoveDuplicates
{
    static string DoRemoveDuplicates(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (!result.Contains(text[i]))
                result += text[i];
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        Console.WriteLine("After removing duplicates: " + DoRemoveDuplicates(s));
    }
}
