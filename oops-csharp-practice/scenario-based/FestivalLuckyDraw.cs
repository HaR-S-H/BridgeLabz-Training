using System;

class FestivalLuckyDraw
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter your lucky draw number (or -1 to exit): ");
            string input = Console.ReadLine();

            int number;
            bool isValid = int.TryParse(input, out number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            if (number == -1)
            {
                Console.WriteLine("Lucky draw ended.");
                break;
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("🎁 Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time.");
            }
        }

        Console.ReadLine();
    }
}
