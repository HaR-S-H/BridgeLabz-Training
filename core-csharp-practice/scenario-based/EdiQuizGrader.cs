using System;

class EduQuizGrader
{
    static void Main()
    {
        string[] correctAnswers = {
            "A", "B", "C", "D", "A",
            "C", "B", "D", "A", "C"
        };

        string[] studentAnswers = new string[10];

        Console.WriteLine("Enter student answers (A/B/C/D):\n");

        for (int i = 0; i < studentAnswers.Length; i++)
        {
            Console.Write("Question " + (i + 1) + ": ");
            studentAnswers[i] = Console.ReadLine();
        }

        int score = CalculateScore(correctAnswers, studentAnswers);

        double percentage = (score / 10.0) * 100;

        Console.WriteLine("\nFinal Score: " + score + "/10");
        Console.WriteLine("Percentage: " + percentage + "%");

        if (percentage >= 40)
            Console.WriteLine("Result: PASS");
        else
            Console.WriteLine("Result: FAIL");
    }

    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        Console.WriteLine("\n--- Quiz Feedback ---");

        for (int i = 0; i < correct.Length; i++)
        {
            if (student[i].Equals(correct[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Question " + (i + 1) + ": Incorrect");
            }
        }

        return score;
    }
}
