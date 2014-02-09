using System;

class PrintSpiralFilledMatrix
{
    //13.* Write a program that reads a positive integer number N (N < 20) from console 
    //and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0 || n > 19)
        {
            Console.Write("Enter N (N > 0): ");
        }

        int number = 1;
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n / 2 + 1; i++)
        {
            for (int j = i; j < n - i; j++)
            {
                matrix[i, j] = number++;
            }

            for (int j = i + 1; j < n - i; j++)
            {
                matrix[j, n - i - 1] = number++;
            }

            for (int j = (int)n - i - 2; j >= i; j--)
            {
                matrix[n - i - 1, j] = number++;
            }

            for (int j = (int)n - i - 2; j >= i + 1; j--)
            {
                matrix[j, i] = number++;
            }
        }

        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
