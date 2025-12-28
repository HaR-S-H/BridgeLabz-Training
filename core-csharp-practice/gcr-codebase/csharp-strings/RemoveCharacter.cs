using System;

class RemoveCharacter
{
    static string RemoveChar(string text, char ch)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ch)
                result += text[i];
        }

        return result;
    }

    static void Main()
    {
        string str = "Hello World";
        char remove = 'l';

        Console.WriteLine("Modified String: " + RemoveChar(str, remove));
    }
}
