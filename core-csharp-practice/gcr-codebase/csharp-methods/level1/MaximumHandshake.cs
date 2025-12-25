using System;

class MaximumHandshake
{
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);
        Console.WriteLine("Maximum handshakes = " + handshakes);
    }
}
