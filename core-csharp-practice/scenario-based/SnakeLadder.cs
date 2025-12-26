using System;

class SnakeLadder
{
    public static int RollDice()
    {
        return new Random().Next(1, 7);
    }
    // public static void MovePlayer(int old,int value) { 
    //     return 
    // }
    public static int ApplySnakeOrLadder(int value)
    {
        int[][] snakes = { new int[] { 17, 7 }, new int[] { 54, 34 }, new int[] { 62, 20 }, new int[] { 87, 11 }, new int[] { 95, 39 }, new int[] { 98, 5 } };
        int[][] ladder = { new int[] { 7, 90 }, new int[] { 34, 50 }, new int[] { 19, 30 }, new int[] { 60, 85 }, new int[] { 81, 95 } };
        for (int i = 0; i < snakes.Length; i++)
        {
            if (value == snakes[i][0])
            {
                return snakes[i][1];
            }
        }
        for (int i = 0; i < ladder.Length; i++)
        {
            if (value == ladder[i][0])
            {
                return ladder[i][1];
            }
        }
        return -1;
    }
    public static bool CheckWin(int value)
    {
        if (value == 100)
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        Console.WriteLine("Welcome to Snake and Ladder Game");
        Console.WriteLine("please enter number of players: ");
        int numPlayers = int.Parse(Console.ReadLine());
        if (numPlayers < 2 || numPlayers > 4)
        {
            Console.WriteLine("Invalid number of players. Please enter a number between 2 and 4.");
            return;
        }
        string[] playerNames = new string[numPlayers];
        int[] positions = new int[numPlayers];
        for (int i = 0; i < numPlayers; i++)
        {
            Console.WriteLine("Enter name of player " + (i + 1) + ": ");
            playerNames[i] = Console.ReadLine();
        }
        int index = 0;
        while (true)
        {
            Console.WriteLine($"{playerNames[index]}'s turn. Press Enter to roll the dice.");
            Console.ReadLine();
            int value = RollDice();
            Console.WriteLine($"the dice value :{value}");
            if ((positions[index] + value) > 100)
            {
                Console.WriteLine($"{playerNames[index]} cannot move, needs exact roll to reach 100.");
                continue;
            }
            if (CheckWin(positions[index] + value))
            {
                Console.WriteLine($"{playerNames[index]} wins the game!");
                break;
            }
            int newValue = ApplySnakeOrLadder(positions[index] + value);

            if (newValue == -1)
            {
                //   positions[index] += value;
            }
            else
            {
                if (positions[index] + value < newValue)
                {
                    Console.WriteLine($"{playerNames[index]} moved from {positions[index]} to {newValue}.");
                    Console.WriteLine($"{playerNames[index]} hit a ladder!");
                    positions[index] = newValue;
                    continue;
                }
                else
                {
                    Console.WriteLine($"{playerNames[index]} moved from {positions[index]} to {newValue}.");
                    Console.WriteLine($"{playerNames[index]} hit a snake!");
                    positions[index] = newValue;
                    continue;
                }
            }
            Console.WriteLine($"{playerNames[index]} moved from {positions[index]} position {positions[index] + value}.");
            positions[index] += value;
            index = (index + 1) % numPlayers;

        }

    }
}