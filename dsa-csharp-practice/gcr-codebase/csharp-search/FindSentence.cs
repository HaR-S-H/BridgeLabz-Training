using System;

class Program
{
    static void Main()
    {
        string[] sentences = {
            "I love programming",
            "C# is powerful",
            "Hello world example"
        };

        string word = "powerful";
        int index = -1;

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word))
            {
                index = i;
                break;
            }
        }

        Console.WriteLine(index); // 1
    }
}
