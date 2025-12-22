using System;
class LeapYearWithSingleIfAndOperator
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());
        if (y >= 1582 && ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0))
        {
            Console.WriteLine(y + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(y + " is not a Leap Year");
        }
    }
}