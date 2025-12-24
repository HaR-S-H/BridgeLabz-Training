using System;

class PensDistribution
{
    static void Main()
    {       //total pens and students
        int pens = 14;

        int students = 3;
        //calculate pens per student and remaining pens
        int pensStudent = pens / students;
        
        int remainingPens = pens % students;
        //print the result
        Console.WriteLine($"The Pen Per Student is {pensStudent} and the remaining pen not distributed is {remainingPens}");
    }
}
