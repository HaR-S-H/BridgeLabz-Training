using System;

class ArrayCopy
{
    static void Main()
    {   // take number of rows and columns as input from user
        Console.WriteLine("enter rows");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("enter columns");
        int columns = int.Parse(Console.ReadLine());
        // declare and initialize 2D array
        int[,] matrix = new int[rows, columns];
        // take elements of 2D array as input from user
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine("enter element");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        // copy elements from 2D array to 1D array
        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        Console.WriteLine("1D Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
