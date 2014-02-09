namespace _02.FindsMaxSumOf3by3Square
{
    using System;

    class FindsMaxSumOf3by3Square
    {
        //02.Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter number of rows (N): ");
            //int rowsCount = 0;
            //while (!int.TryParse(Console.ReadLine(), out rowsCount) || rowsCount < 1)
            //{
            //    Console.Write("Enter valid number of rows (N): ");
            //}

            //Console.Write("Enter number of colomns (M): ");
            //int colsCount = 0;
            //while (!int.TryParse(Console.ReadLine(), out colsCount) || colsCount < 1)
            //{
            //    Console.Write("Enter valid number of colomns (M): ");
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Enter only integer numbers!");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("Enter array numbers");

            //int[,] matrix = new int[rowsCount, colsCount];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        int number = 0;
            //        Console.Write("Enter matrix[{0},{1}] number: ", i, j);
            //        while (!int.TryParse(Console.ReadLine(), out number))
            //        {
            //            Console.Write("Enter valid matrix[{0},{1}] number: ", i, j);
            //        }
            //        matrix[i, j] = number;
            //    }
            //}

            #endregion

            int[,] matrix = {
                  { 0, 2, 4, 0, 9, 25 },
                  { 7, 1, 3, 3, 2, 1 },
                  { 1, 3, 9, 80, 5, 6 },
                  { 4, 6, 7, 9, 1, 30 }
               };
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            int squareSize = 3;

            for (int row = 0; row < matrix.GetLength(0) - (squareSize - 1); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - (squareSize - 1); col++)
                {
                    long tempSum = GetSquareSum(row, col, squareSize, matrix);
                    if (tempSum > bestSum)
                    {
                        bestSum = tempSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Print the result
            PrintSquare(bestRow, bestCol, squareSize, matrix);

            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }

        static long GetSquareSum(int row, int col, int squareSize, int[,] matrix)
        {
            long sum = 0;
            for (int i = row; i < row + squareSize; i++)
            {
                for (int j = col; j < col + squareSize; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        static void PrintSquare(int row, int col, int squareSize, int[,] matrix)
        {
            for (int i = row; i < row + squareSize; i++)
            {
                for (int j = col; j < col + squareSize; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
