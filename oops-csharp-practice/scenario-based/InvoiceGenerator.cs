using System;

class InvoiceGenerator
{
    // Method to parse invoice string
    public static string[] ParseInvoice(string input)
    {
        // Split tasks using comma
        string[] tasks = input.Split(',');

        return tasks;
    }

    // Method to calculate total amount
    public static int GetTotalAmount(string[] tasks)
    {
        int totalAmount = 0;

        foreach (string task in tasks)
        {
            // Split task name and amount
            string[] parts = task.Split('-');

            if (parts.Length == 2)
            {
                // Extract amount part and remove INR
                string amountPart = parts[1].Replace("INR", "").Trim();

                int amount = Convert.ToInt32(amountPart);
                totalAmount += amount;
            }
        }

        return totalAmount;
    }

    static void Main()
    {
        Console.WriteLine("Enter invoice details:");
        string input = Console.ReadLine();

        string[] tasks = ParseInvoice(input);

        Console.WriteLine("\nInvoice Details:");
        foreach (string task in tasks)
        {
            Console.WriteLine(task.Trim());
        }

        int total = GetTotalAmount(tasks);

        Console.WriteLine("\nTotal Invoice Amount: " + total + " INR");
        Console.ReadLine();
    }
}
