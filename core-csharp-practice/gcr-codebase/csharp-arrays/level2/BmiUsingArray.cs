using System;

class BmiUsingArray
{
    static void Main()
    {
        Console.WriteLine("Enter number of persons:");
        int number = int.Parse(Console.ReadLine());

        double[] weight = new double[number];
        double[] height = new double[number];
        double[] bmi = new double[number];
        string[] status = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter weight:");
            weight[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height:");
            height[i] = double.Parse(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 25)
                status[i] = "Normal";
            else if (bmi[i] < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Height: " + height[i] +
                              " Weight: " + weight[i] +
                              " BMI: " + bmi[i] +
                              " Status: " + status[i]);
        }
    }
}
