using System;

class StudentGradesUsingMultiArray
{
    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int number = int.Parse(Console.ReadLine());

        int[,] marks = new int[number, 3];
        double[] percentage = new double[number];
        string[] grade = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Enter Physics marks:");
            marks[i, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Chemistry marks:");
            marks[i, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maths marks:");
            marks[i, 2] = int.Parse(Console.ReadLine());

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

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
