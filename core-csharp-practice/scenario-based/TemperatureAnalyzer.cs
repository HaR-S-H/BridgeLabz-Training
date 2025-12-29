using System;

class TemperatureAnalyzer
{
    static void AnalyzeTemperature(float[,] tempData)
    {
        int hottestDay = 0;
        int coldestDay = 0;

        float hottestAvg = float.MinValue;
        float coldestAvg = float.MaxValue;

        for (int day = 0; day < 7; day++)
        {
            float dailySum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                dailySum += tempData[day, hour];
            }

            float dailyAvg = dailySum / 24;
            Console.WriteLine("Average temperature of Day " + (day + 1) + " : " + dailyAvg);

            if (dailyAvg > hottestAvg)
            {
                hottestAvg = dailyAvg;
                hottestDay = day;
            }

            if (dailyAvg < coldestAvg)
            {
                coldestAvg = dailyAvg;
                coldestDay = day;
            }
        }

        Console.WriteLine("\nHottest Day : Day " + (hottestDay + 1));
        Console.WriteLine("Coldest Day : Day " + (coldestDay + 1));
    }

    static void Main()
    {
        float[,] temperatures = new float[7, 24];

        Console.WriteLine("Enter hourly temperature data for 7 days:");

        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("\nDay " + (day + 1));
            for (int hour = 0; hour < 24; hour++)
            {
                temperatures[day, hour] = float.Parse(Console.ReadLine());
            }
        }

        AnalyzeTemperature(temperatures);
    }
}
