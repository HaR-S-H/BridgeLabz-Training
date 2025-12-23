using System;

class StudentGrades
{
    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int number = int.Parse(Console.ReadLine());

        int[] physics = new int[number];
        int[] chemistry = new int[number];
        int[] maths = new int[number];
        double[] percentage = new double[number];
        string[] grade = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter Physics marks:");
            physics[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry marks:");
            chemistry[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths marks:");
            maths[i] = int.Parse(Console.ReadLine());

            percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;

            if (percentage[i] >= 75)
                grade[i] = "A";
            else if (percentage[i] >= 60)
                grade[i] = "B";
            else if (percentage[i] >= 40)
                grade[i] = "C";
            else
                grade[i] = "Fail";
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Percentage: " + percentage[i] +
                              " Grade: " + grade[i]);
        }
    }
}
