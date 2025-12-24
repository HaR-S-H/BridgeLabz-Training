using System;
class BmiCalculator
{
    static void Main()
    {   // take weight and height as input from user
        Console.Write("enter weight");
        double w = double.Parse(Console.ReadLine());
        Console.Write("enter height");
        double h = double.Parse(Console.ReadLine());
    // calculate BMI
        double heightM = h / 100;
        double bmi = w / (heightM * heightM);
        Console.WriteLine("BMI: " + bmi);
        // determine BMI category
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