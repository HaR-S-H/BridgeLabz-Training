using System;

class SimpleInterest
{
    static double CalculateSimpleInterest(double p, double r, double t)
    {
        return (p * r * t) / 100;
    }

    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double si = CalculateSimpleInterest(principal, rate, time);

        Console.WriteLine("The Simple Interest is " + si +
            " for Principal " + principal +
            ", Rate of Interest " + rate +
            " and Time " + time);
    }
}
