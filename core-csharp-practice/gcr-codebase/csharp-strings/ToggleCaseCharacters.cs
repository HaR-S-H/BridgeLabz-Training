using System;

class ToggleCaseCharacters
{
    static string ToggleCase(string text)
    {
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else if (char.IsLower(ch))
                result += char.ToUpper(ch);
            else
                result += ch;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        Console.WriteLine("Toggled String: " + ToggleCase(s));
    }
}
