using System;

class Trigonometry
{
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;
        double sin = Math.Sin(radians);
        double cos = Math.Cos(radians);
        double tan = Math.Tan(radians);

        return new double[] { sin, cos, tan };
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);
        Console.WriteLine("Sin = " + result[0]);
        Console.WriteLine("Cos = " + result[1]);
        Console.WriteLine("Tan = " + result[2]);
    }
}
