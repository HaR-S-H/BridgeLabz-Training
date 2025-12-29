using System;

class ParagraphAnalyzer
{
    static int WordCount(string para)
    {
        if (para.Trim().Length == 0)
            return 0;

        string[] words = para.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    static string LongestWord(string para)
    {
        if (para.Trim().Length == 0)
            return "No words found";

        string[] words = para.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string longest = words[0];

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        return longest;
    }

    static string ReplaceWord(string para, string oldWord, string newWord)
    {
        if (para.Trim().Length == 0)
            return para;

        string[] words = para.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        foreach (string word in words)
        {
            if (word.Equals(oldWord, StringComparison.OrdinalIgnoreCase))
                result += newWord + " ";
            else
                result += word + " ";
        }

        return result.Trim();
    }

    static void Main()
    {
        Console.WriteLine("Enter paragraph:");
        string para = Console.ReadLine();

        if (para.Trim().Length == 0)
        {
            Console.WriteLine("Paragraph is empty or contains only spaces.");
            return;
        }

        Console.WriteLine("Word Count: " + WordCount(para));
        Console.WriteLine("Longest Word: " + LongestWord(para));

        Console.WriteLine("\nEnter word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        para = ReplaceWord(para, oldWord, newWord);

        Console.WriteLine("\nUpdated Paragraph:");
        Console.WriteLine(para);
    }
}
