using System;

class StudentMarks
{
    static void Main()
    {
        Console.Write("Enter Students Count: ");
        int n = int.Parse(Console.ReadLine());

        int[,] marks = new int[n, 3];
        Random r = new Random();

        for (int i = 0; i < n; i++)
            for (int j = 0; j < 3; j++)
                marks[i, j] = r.Next(40, 100);

        Console.WriteLine("Phy\tChem\tMath\tTotal\tAvg\t%");

        for (int i = 0; i < n; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double avg = total / 3.0;
            double percent = (total / 300.0) * 100;

            Console.WriteLine($"{marks[i, 0]}\t{marks[i, 1]}\t{marks[i, 2]}\t{total}\t{Math.Round(avg, 2)}\t{Math.Round(percent, 2)}");
        }
    }
}
