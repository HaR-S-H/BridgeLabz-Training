using System;

class BmiUsingArray
{
    static void Main()
    {   // take number of persons as input
        Console.WriteLine("enter number of persons");
        // read the number
        int number = int.Parse(Console.ReadLine());
        //  declare arrays to store weight, height, bmi and status
        double[] weight = new double[number];
        double[] height = new double[number];
        double[] bmi = new double[number];
        string[] status = new string[number];
    // take weight and height as input and calculate bmi and status
        for (int i = 0; i < number; i++)
        {   // read weight
            Console.WriteLine("enter weight");

            weight[i] = double.Parse(Console.ReadLine());
            // read height
            Console.WriteLine("enter height");
            
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
