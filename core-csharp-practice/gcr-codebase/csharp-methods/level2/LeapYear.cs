using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (IsLeapYear(year))
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }

    static bool IsLeapYear(int year)
    {
        if (year < 1582)
            return false;

        if (year % 400 == 0)
            return true;

        if (year % 100 == 0)
            return false;

        return year % 4 == 0;
    }
}
