using System;
class BmiCalculator
{
    static void Main()
    {
        Console.Write("Enter weight (kg): ");
        double w = double.Parse(Console.ReadLine());
        Console.Write("Enter height (cm): ");
        double h = double.Parse(Console.ReadLine());

        double heightM = h / 100;
        double bmi = w / (heightM * heightM);
        Console.WriteLine("BMI: " + bmi);

        if (bmi < 18.5)
            Console.WriteLine("Underweight");
        else if (bmi < 24.9)
            Console.WriteLine("Normal weight");
        else if (bmi < 29.9)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}