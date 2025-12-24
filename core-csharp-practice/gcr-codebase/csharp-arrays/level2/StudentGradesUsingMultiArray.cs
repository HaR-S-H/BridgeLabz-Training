using System;

class StudentGradesUsingMultiArray
{
    static void Main()
    {// take number of students as input
        Console.WriteLine("enter number of students");
        int number = int.Parse(Console.ReadLine());
    // declare multi-dimensional array to store marks of 3 subjects
        int[,] marks = new int[number, 3];
        double[] percentage = new double[number];
        string[] grade = new string[number];
        //  take marks as input and calculate percentage and grade
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("enter Physics marks");

            marks[i, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Chemistry marks");

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
// display percentage and grade of each student
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("Percentage: " + percentage[i] +
                              " Grade: " + grade[i]);
        }
    }
}
