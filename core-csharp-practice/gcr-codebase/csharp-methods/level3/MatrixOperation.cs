using System;

class MatrixOperations
{
    static int[,] CreateMatrix(int r, int c)
    {
        int[,] m = new int[r, c];
        Random rand = new Random();
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                m[i, j] = rand.Next(1, 10);
        return m;
    }

    static int[,] Add(int[,] a, int[,] b)
    {
        int[,] res = new int[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                res[i, j] = a[i, j] + b[i, j];
        return res;
    }

    static int[,] Transpose(int[,] a)
    {
        int[,] t = new int[2, 2];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                t[j, i] = a[i, j];
        return t;
    }

    static int Determinant2x2(int[,] m)
    {
        return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
    }

    static void Display(int[,] m)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write(m[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] A = CreateMatrix(2, 2);
        int[,] B = CreateMatrix(2, 2);

        Console.WriteLine("Matrix A");
        Display(A);

        Console.WriteLine("Matrix B");
        Display(B);

        Console.WriteLine("Addition");
        Display(Add(A, B));

        Console.WriteLine("Transpose of A");
        Display(Transpose(A));

        Console.WriteLine("Determinant of A = " + Determinant2x2(A));
    }
}
