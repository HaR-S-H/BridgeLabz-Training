using System;

class EmployeeBonus
{
    static void Main()
    {
        int employees = 10;
        double[,] data = new double[employees, 2];
        double totalBonus = 0;

        Random r = new Random();

        for (int i = 0; i < employees; i++)
        {
            data[i, 0] = r.Next(20000, 99999);
            data[i, 1] = r.Next(1, 10);
        }

        Console.WriteLine("Salary\tYears\tBonus\tNew Salary");

        for (int i = 0; i < employees; i++)
        {
            double bonusRate = data[i, 1] > 5 ? 0.05 : 0.02;
            double bonus = data[i, 0] * bonusRate;
            totalBonus += bonus;

            Console.WriteLine($"{data[i, 0]}\t{data[i, 1]}\t{bonus}\t{data[i, 0] + bonus}");
        }

        Console.WriteLine("Total Bonus = " + totalBonus);
    }
}
