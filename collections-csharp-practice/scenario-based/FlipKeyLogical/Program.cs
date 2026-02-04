using System;
using System.Text;
class Program
{
    public static string CleanseAndInvert(string input)
    {
        if (input == null || input.Length < 6)
        {
            return "";
        }
        if (!input.All(char.IsLetter))
        {
            return "";
        }
        StringBuilder builder = new StringBuilder(input.ToLower());
        for (int i = 0; i < builder.Length; i++)
        {
            if (((int)builder[i]) % 2 == 0)
            {
                builder.Remove(builder[i], 1);
            }
        }
            Reverse(builder);
            for (int i = 0; i < builder.Length; i++)
            {
                if (i % 2 == 0)
                {
                    builder[i] = char.ToUpper(builder[i]);
                }
            }
            return builder.ToString();
        

    }
    public static void Reverse(StringBuilder str)
    {
        int i = 0;
        int j = str.Length - 1;
        while (i < j)
        {
            char temp = str[i];
            str[i] = str[j];
            str[j] = temp;
            i++;
            j--;
        }
    }
    static void Main()
    {
        string input = Console.ReadLine();
       Console.WriteLine(CleanseAndInvert(input));
    }
}