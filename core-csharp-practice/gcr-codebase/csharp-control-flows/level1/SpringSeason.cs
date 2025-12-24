using System;

class SpringSeason
{
    static void Main(string[] args)
    {   // read month and day from command line arguments
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        if ((month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20))
            Console.WriteLine("its a spring season");
        else
            Console.WriteLine("not a spring season");
    }
}
