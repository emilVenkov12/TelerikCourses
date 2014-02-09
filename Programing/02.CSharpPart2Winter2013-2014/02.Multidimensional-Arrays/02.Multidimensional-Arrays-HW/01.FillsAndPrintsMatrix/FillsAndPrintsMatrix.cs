namespace _01.FillsAndPrintsMatrix
{
    using System;
    using System.Linq;

    class FillsAndPrintsMatrix
    {
        //01.Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter n: ");
            //int matrixSize = 0;
            //while (!int.TryParse(Console.ReadLine(), out matrixSize)  || matrixSize < 1)
            //{
            //    Console.Write("Enter valid n: ");
            //}

            #endregion

            int matrixSize = 4;

            int[,] matrix = new int[matrixSize, matrixSize];

            //first example
            VerticalFillMatrix(matrix);
            PrintMatrix(matrix);

            //second example
            Console.WriteLine();
            matrix = new int[matrixSize, matrixSize];
            FillMatrixSinusoidal(matrix);
            PrintMatrix(matrix);

            //third example
            Console.WriteLine();
            matrix = new int[matrixSize, matrixSize];
            DiagonalFillMatrix(matrix);
            PrintMatrix(matrix);

            //fourth example
            Console.WriteLine();
            matrix = new int[matrixSize, matrixSize];
            SpiralFillMatrix(matrix);
            PrintMatrix(matrix);

            //just for fun
            
        }

        private static void SpiralFillMatrix(int[,] matrix)
        {
            int number = 1;
            int n = matrix.GetLength(0);

            for (int i = 0; i < n / 2 + 1; i++)
            {
                //down
                for (int j = i ; j < n - i; j++)
                {
                    matrix[j, i] = number++;
                }

                //right
                for (int j = i + 1; j < n - i; j++)
                {
                    matrix[n - i - 1, j] = number++;
                }

                //up
                for (int j = (int)n - i - 2; j >= i; j--)
                {
                    matrix[j, n - 1 - i] = number++;
                }

                //left
                for (int j = n - i - 2; j >= i + 1; j--)
                {
                    matrix[i, j] = number++;
                }
            }
        }

        private static void DiagonalFillMatrix(int[,] matrix)
        {
            int number = 1;

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                int row = i,
                    col = 0;
                while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
                {
                    matrix[row++, col++] = number++;
                }
            }

            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                int row = 0,
                    col = i;
                while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
                {
                    matrix[row++, col++] = number++;
                }
            }

        }

        private static void FillMatrixSinusoidal(int[,] matrix)
        {
            int number = 1;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[j, i] = number++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[j, i] = number++;
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void VerticalFillMatrix(int[,] matrix)
        {
            int number = 1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, i] = number++;
                }
            }
        }
    }
}
