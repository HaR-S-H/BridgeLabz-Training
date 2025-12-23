using System;

class ZaraBonus
{
    static void Main()
    {
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonusAmount = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;

        // Taking input from user
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter salary of employee " + (i + 1));
            salary[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter years of service of employee " + (i + 1));
            yearsOfService[i] = double.Parse(Console.ReadLine());

            // Validation for invalid input
            if (salary[i] <= 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter again.");
                i--;   // decrement index to re-enter data
                continue;
            }
        }

        // Calculating bonus and new salary
        for (int i = 0; i < 10; i++)
        {
            if (yearsOfService[i] > 5)
            {
                bonusAmount[i] = salary[i] * 0.05;
            }
            else
            {
                bonusAmount[i] = salary[i] * 0.02;
            }

            newSalary[i] = salary[i] + bonusAmount[i];

            totalBonus = totalBonus + bonusAmount[i];
            totalOldSalary = totalOldSalary + salary[i];
            totalNewSalary = totalNewSalary + newSalary[i];
        }

        // Displaying results
        Console.WriteLine("\nEmployee Salary Details:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                "Employee " + (i + 1) +
                " | Old Salary: " + salary[i] +
                " | Bonus: " + bonusAmount[i] +
                " | New Salary: " + newSalary[i]
            );
        }

        Console.WriteLine("\nTotal Old Salary = " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid = " + totalBonus);
        Console.WriteLine("Total New Salary = " + totalNewSalary);
    }
}
