using System;

class TotalIncome
{
    static void Main()
    {   // take salary and bonus as input from user
        Console.Write("enter salary");

        double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter bonus");

        
        double bonus = Convert.ToDouble(Console.ReadLine());

        double totalIncome = salary + bonus;
        // print the result
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }
}
