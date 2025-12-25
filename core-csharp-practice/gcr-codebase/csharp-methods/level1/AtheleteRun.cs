using System;

class AthleteRun
{
    static double CalculateRounds(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return 5000 / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double s1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double s2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double s3 = Convert.ToDouble(Console.ReadLine());

        double rounds = CalculateRounds(s1, s2, s3);
        Console.WriteLine("Number of rounds required = " + rounds);
    }
}
