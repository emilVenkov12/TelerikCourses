namespace _05.ReadSquareMatrixFromFile
{
    using System;
    using System.IO;

    class ReadSquareMatrixFromFile
    {
        //05.Write a program that reads a text file containing a square matrix of numbers and 
        //finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
        //The first line in the input file contains the size of matrix N. Each of the next N lines 
        //contain N numbers separated by space. The output should be a single number in a separate text file. 
        //Example: 
        //4
        //2 3 3 4
        //0 2 3 4	------>		17
        //3 7 1 2
        //4 3 3 2

        static void Main()
        {
           using (StreamReader srInputFile = new StreamReader(@"../../textFiles\inputFile.txt"))
            {
                int matrixSize = int.Parse(srInputFile.ReadLine());

                int[,] matrix = new int[matrixSize, matrixSize];
                for (int row = 0; row < matrixSize; row++)
                {
                    string[] numbers = srInputFile.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                    for (int col = 0; col < matrixSize; col++)
                    {
                        matrix[row, col] = int.Parse(numbers[col]);
                    }
                }

                long bestSum = long.MinValue;              

                int squareSize = 2;

                for (int row = 0; row < matrix.GetLength(0) - (squareSize - 1); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - (squareSize - 1); col++)
                    {
                        long tempSum = GetSquareSum(row, col, squareSize, matrix);
                        if (tempSum > bestSum)
                        {
                            bestSum = tempSum;
                        }
                    }
                }

                Console.WriteLine("Best sum is {0}", bestSum);

            }
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
    }
}
