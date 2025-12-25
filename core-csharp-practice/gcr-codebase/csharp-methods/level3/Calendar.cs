using System;

class Calendar
{
    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year))
            return 29;
        return days[month - 1];
    }

    static int GetFirstDay(int month, int year)
    {
        int d = 1;
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        return (d + x + (31 * m0) / 12) % 7;
    }

    static void Main()
    {
        Console.Write("Enter Month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSun Mon Tue Wed Thu Fri Sat");

        int firstDay = GetFirstDay(month, year);
        int days = GetDaysInMonth(month, year);

        for (int i = 0; i < firstDay; i++)
            Console.Write("    ");

        for (int day = 1; day <= days; day++)
        {
            Console.Write("{0,3} ", day);
            if ((day + firstDay) % 7 == 0)
                Console.WriteLine();
        }
    }
}
