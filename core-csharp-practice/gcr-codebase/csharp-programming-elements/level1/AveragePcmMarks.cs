using System;

class AveragePcmMarks
{
    static void Main()
    {  //marks in subjects
        int maths = 94, physics = 95, chemistry = 96;
        //calculate average
        double average = (maths + physics + chemistry) / 3.0;
        //print average
        Console.WriteLine($"Sam's average mark in PCM is {average}%");
    }
}
