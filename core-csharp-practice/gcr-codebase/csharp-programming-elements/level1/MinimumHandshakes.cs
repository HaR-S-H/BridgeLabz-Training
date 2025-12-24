using System;

class MinimumHandshakes
{
    static void Main()
    {//take number of students as input from user
        Console.Write("enter number of students");

        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        //calculate maximum number of handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        //print the result
        Console.WriteLine($"The maximum number of handshakes is {handshakes}");
    }
}
