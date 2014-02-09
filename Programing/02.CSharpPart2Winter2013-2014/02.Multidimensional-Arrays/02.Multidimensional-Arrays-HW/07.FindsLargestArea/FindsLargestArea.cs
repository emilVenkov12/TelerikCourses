namespace _07.FindsLargestArea
{
    using System;

    class FindsLargestArea
    {
        //07.* Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.
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
                  { 1, 3, 2, 2, 2, 4 },
                  { 3, 3, 3, 2, 4, 4 },
                  { 4, 3, 1, 2, 3, 3 },
                  { 4, 2, 1, 2, 2, 2 },
                  { 4, 2, 2, 2, 1, 1 }
               };
            bool[,] usedCells = new bool[5, 6];

            int bestLenght = int.MinValue;
            int bestValue = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!usedCells[i, j])
                    {
                        usedCells[i, j] = true;

                        int tempAreaLenght = GetAreaLenght(matrix, i, j, usedCells);

                        if (tempAreaLenght > bestLenght)
                        {
                            bestLenght = tempAreaLenght;
                            bestValue = matrix[i, j];
                        } 
                    }
                }
            }

            Console.WriteLine("{0} -> {1} times", bestValue, bestLenght);
        }

        private static int GetAreaLenght(int[,] matrix, int row, int col, bool[,] usedCells)
        {
            int areaLength = 1;
            //up
            if (row - 1 >= 0 && !usedCells[row - 1, col] && matrix[row - 1, col] == matrix[row, col])
            {
                usedCells[row - 1, col] = true;
                areaLength += GetAreaLenght(matrix, row - 1, col, usedCells);
            }

            //left
            if (col - 1 >= 0 && !usedCells[row, col - 1] && matrix[row, col - 1] == matrix[row, col])
            {
                usedCells[row, col - 1] = true;
                areaLength += GetAreaLenght(matrix, row, col - 1, usedCells);
            }

            //down
            if (row + 1 < matrix.GetLength(0) && !usedCells[row + 1, col] && matrix[row + 1, col] == matrix[row, col])
            {
                usedCells[row + 1, col] = true;
                areaLength += GetAreaLenght(matrix, row + 1, col, usedCells);
            }

            //right
            if (col + 1 < matrix.GetLength(1) && !usedCells[row, col + 1] && matrix[row, col + 1] == matrix[row, col])
            {
                usedCells[row, col + 1] = true;
                areaLength += GetAreaLenght(matrix, row, col + 1, usedCells);
            }

            return areaLength;
        }
    }
}
