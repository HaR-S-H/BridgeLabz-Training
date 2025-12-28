using System;

class MostFrequentCharacter
{
    static char MostFrequentChar(string text)
    {
        int maxCount = 0;
        char maxChar = text[0];

        for (int i = 0; i < text.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < text.Length; j++)
            {
                if (text[i] == text[j])
                    count++;
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxChar = text[i];
            }
        }

        return maxChar;
    }

    static void Main()
    {
        string s = "success";
        Console.WriteLine("Most Frequent Character: " + MostFrequentChar(s));
    }
}
