namespace _03.FindsLongestSeqOfStrings
{
    using System;
    using System.Linq;

    class FindsLongestSeqOfStrings
    {
        //03.We are given a matrix of strings of size N x M. Sequences in the matrix we define 
        //as sets of several neighbor elements located on the same line, column or diagonal. 
        //Write a program that finds the longest sequence of equal strings in the matrix.

        //TODO: Dynamic programing - check for eaerly visited cells
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

            //string[,] matrix = new string[rowsCount, colsCount];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("Enter matrix[{0},{1}] string: ", i, j);

            //        string str = Console.ReadLine();

            //        while (!str.All(char.IsLetter) || String.IsNullOrEmpty(str))
            //        {
            //            Console.Write("Enter valid matrix[{0},{1}] string (only letters allowed): ", i, j);
            //            str = Console.ReadLine();
            //        }
            //        matrix[i, j] = str;
            //    }
            //}

            #endregion

            //string[,] matrix = new string[,] 
            //    {
            //        { "ha", "fifi", "ho", "hi" },
            //        { "fo", "ha", "hi", "xx" },
            //        { "xxx", "ho", "ha", "xx" }
            //    };

            string[,] matrix = 
                {
                    { "s", "qq", "s" },
                    { "pp", "pp", "s" }, 
                    { "pp", "qq", "s" }
                };

            int bestLength = int.MinValue;
            string bestString = String.Empty;

            int dirRow = 0,
                dirCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //cols
                    dirRow = 0;
                    dirCol = 1;
                    int tempLenght = GetSeqLengthInDir(matrix, i, j, dirRow, dirCol);
                    if (tempLenght > bestLength)
                    {
                        bestLength = tempLenght;
                        bestString = matrix[i, j];
                    }

                    //rows
                    dirRow = 1;
                    dirCol = 0;
                    tempLenght = GetSeqLengthInDir(matrix, i, j, dirRow, dirCol);
                    if (tempLenght > bestLength)
                    {
                        bestLength = tempLenght;
                        bestString = matrix[i, j];
                    }

                    //first diagonal
                    dirRow = 1;
                    dirCol = 1;
                    tempLenght = GetSeqLengthInDir(matrix, i, j, dirRow, dirCol);
                    if (tempLenght > bestLength)
                    {
                        bestLength = tempLenght;
                        bestString = matrix[i, j];
                    }

                    //second diagonal
                    dirRow = 1;
                    dirCol = -1;
                    tempLenght = GetSeqLengthInDir(matrix, i, j, dirRow, dirCol);
                    if (tempLenght > bestLength)
                    {
                        bestLength = tempLenght;
                        bestString = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("{0} -> {1} times", bestString, bestLength);
        }

        static int GetSeqLengthInDir(string[,] matrix, int row, int col, int dirRow, int dirCol)
        {
            int _row = row,
                _col = col;

            int currLength = 0;

            while (IsValid(_row, _col, matrix) && matrix[row, col] == matrix[_row, _col])
            {
                currLength++;

                _row += dirRow;
                _col += dirCol;
            }

            return currLength;
        }

        static bool IsValid(int row, int col, string[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
