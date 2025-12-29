using System;

class StudentScoreManager
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int count = int.Parse(Console.ReadLine());

        int[] scores = new int[count];
        int total = 0;

        for (int i = 0; i < count; i++)
        {
            while (true)
            {
                Console.Write("Enter score of student " + (i + 1) + ": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out scores[i]) && scores[i] >= 0)
                {
                    total += scores[i];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a non-negative number.");
                }
            }
        }

        double average = (double)total / count;

        int highest = scores[0];
        int lowest = scores[0];

        foreach (int score in scores)
        {
            if (score > highest)
                highest = score;

            if (score < lowest)
                lowest = score;
        }

        Console.WriteLine("\nAverage Score: " + average);
        Console.WriteLine("Highest Score: " + highest);
        Console.WriteLine("Lowest Score: " + lowest);

        Console.WriteLine("\nScores above average:");
        foreach (int score in scores)
        {
            if (score > average)
                Console.WriteLine(score);
        }
    }
}
