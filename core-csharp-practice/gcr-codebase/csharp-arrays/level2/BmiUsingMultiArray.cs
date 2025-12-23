using System;

class BmiUsingMultiArray
{
    static void Main()
    {
        Console.WriteLine("Enter number of persons:");
        int number = int.Parse(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];

            Console.WriteLine("Enter weight:");
            personData[i][0] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height:");
            personData[i][1] = double.Parse(Console.ReadLine());

            personData[i][2] = personData[i][0] /
                               (personData[i][1] * personData[i][1]);

            double bmi = personData[i][2];

            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi < 25)
                weightStatus[i] = "Normal";
            else if (bmi < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Weight: " + personData[i][0] +
                              " Height: " + personData[i][1] +
                              " BMI: " + personData[i][2] +
                              " Status: " + weightStatus[i]);
        }
    }
}
