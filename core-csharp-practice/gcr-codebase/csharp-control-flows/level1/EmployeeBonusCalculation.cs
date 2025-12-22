using System;

class EmployeeBonusCalculation
{
    static void Main()
    {
        Console.Write("Enter employee salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

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
