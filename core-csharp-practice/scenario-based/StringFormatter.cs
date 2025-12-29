using System;

class TextFormatter
{
    // display result
    static void ShowResult(string outputText)
    {
        Console.WriteLine("Formatted String :- " + outputText);
    }

    // remove extra spaces and capitalize first letter
    static string RemoveExtraSpaces(string inputText)
    {
        string cleanedText = "";
        bool spaceFlag = false;

        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i] == ' ')
            {
                if (!spaceFlag)
                {
                    cleanedText += inputText[i];
                    spaceFlag = true;
                }
            }
            else
            {
                cleanedText += inputText[i];
                spaceFlag = false;
            }
        }

        cleanedText = cleanedText.Trim();

        if (cleanedText.Length > 0 && cleanedText[0] >= 'a' && cleanedText[0] <= 'z')
        {
            cleanedText = (char)(cleanedText[0] - 32) + cleanedText.Substring(1);
        }

        return cleanedText;
    }

    // capitalize letter after punctuation
    static string CapitalizeSentence(string inputText)
    {
        string resultText = "";
        bool capitalizeNext = false;

        for (int i = 0; i < inputText.Length; i++)
        {
            char ch = inputText[i];

            if (capitalizeNext && ch >= 'a' && ch <= 'z')
            {
                resultText += (char)(ch - 32);
                capitalizeNext = false;
            }
            else
            {
                resultText += ch;
            }

            if (ch == '.' || ch == '?' || ch == '!')
            {
                capitalizeNext = true;
            }
        }

        return resultText;
    }

    // ensure single space after punctuation
    static string FixSpacing(string inputText)
    {
        string spacedText = "";

        for (int i = 0; i < inputText.Length; i++)
        {
            char ch = inputText[i];

            spacedText += ch;

            if (ch == '.' || ch == '?' || ch == '!' || ch == ',')
            {
                if (i + 1 < inputText.Length && inputText[i + 1] != ' ')
                {
                    spacedText += " ";
                }
            }
        }

        return spacedText;
    }

    // call all formatter methods
    static void ApplyFormatting(string textData)
    {
        string step1 = FixSpacing(textData);
        string step2 = CapitalizeSentence(step1);
        string finalText = RemoveExtraSpaces(step2);

        ShowResult(finalText);
    }

    // input method
    static void ReadInput()
    {
        Console.Write("Enter String :- ");
        string userText = Console.ReadLine();

        ApplyFormatting(userText);
    }

    // main method
    static void Main()
    {
        ReadInput();
    }
}
