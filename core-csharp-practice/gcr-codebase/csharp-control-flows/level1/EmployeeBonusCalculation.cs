using System;

class EmployeeBonusCalculation
{
    static void Main()
    {   // take salary and years of service as input from user
        Console.Write("enter salary");
        double salary = double.Parse(Console.ReadLine());
        // read years of service
        Console.Write("enter years of service");
        int yearsOfService = int.Parse(Console.ReadLine());
        // check if years of service is greater than 5
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine($"Bonus amount is {bonus}");
        }
        else
        {
            Console.WriteLine("Employee is not eligible for bonus.");
        }
    }
}
