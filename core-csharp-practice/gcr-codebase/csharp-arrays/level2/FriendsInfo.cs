using System;

class FriendsInfo
{
    static void Main()
    {           // declare arrays for names, ages, and heights


        string[] names = { "Amar", "Akbar", "Anthony" };

        int[] ages = new int[3];
        double[] heights = new double[3];
    //  take age and height as input
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age of " + names[i]);
            ages[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of " + names[i]);
            heights[i] = double.Parse(Console.ReadLine());
        }

        int youngestIndex = 0;

        
        int tallestIndex = 0;
    // find youngest and tallest friend
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        Console.WriteLine("Youngest Friend: " + names[youngestIndex]);
        Console.WriteLine("Tallest Friend: " + names[tallestIndex]);
    }
}
