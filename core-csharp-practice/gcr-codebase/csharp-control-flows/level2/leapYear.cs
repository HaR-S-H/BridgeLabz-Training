using System;
class LeapYear
{
    static void Main()
    {
        Console.Write("enter a year");
        int yr = int.Parse(Console.ReadLine());
        if (yr >= 1582)
        {
            if (yr % 4 == 0)
            {
                if (yr % 100 == 0)
                {
                    if (yr % 400 == 0)
                    {
                        Console.WriteLine(yr + " is a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine(yr + " is not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine(yr + " is a Leap Year");
                }
            }
            else
            {
                Console.WriteLine(yr + " is not a Leap Year");
            }
        }
        else
        {
            Console.WriteLine("Year must be >= 1582");
        }
    }
}
