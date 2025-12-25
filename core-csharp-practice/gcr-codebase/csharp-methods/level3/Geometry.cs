using System;

class Geometry
{
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double[] LineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }

    static void Main()
    {
        Console.Write("x1 y1: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("x2 y2: ");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Distance = " + Distance(x1, y1, x2, y2));

        double[] line = LineEquation(x1, y1, x2, y2);
        Console.WriteLine($"Equation: y = {line[0]}x + {line[1]}");
    }
}
