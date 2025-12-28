using System;

class RepalaceWordString
{
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string[] words = sentence.Split(' ');
        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == oldWord)
                result += newWord;
            else
                result += words[i];

            result += " ";
        }

        return result.Trim();
    }

    static void Main()
    {
        string sentence = "I love programming";
        string oldWord = "love";
        string newWord = "enjoy";

        Console.WriteLine(ReplaceWord(sentence, oldWord, newWord));
    }
}
