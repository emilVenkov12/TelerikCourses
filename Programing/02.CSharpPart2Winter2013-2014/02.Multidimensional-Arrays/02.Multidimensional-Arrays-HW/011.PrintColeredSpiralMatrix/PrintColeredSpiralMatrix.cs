namespace _011.PrintColeredSpiralMatrix
{
    using System;

    class ColoredElement
    {
        public int Value { get; set; }

        public ConsoleColor Color;
    }

    class PrintColeredSpiralMatrix
    {
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

            int matrixSize = 9;

            ColoredElement[,] matrix = new ColoredElement[matrixSize, matrixSize];
            SpiralFillMatrix(matrix);

            Console.ForegroundColor = ConsoleColor.Black;
            PrintMatrix(matrix);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private static void SpiralFillMatrix(ColoredElement[,] matrix)
        {
            int number = 1;
            int n = matrix.GetLength(0);

            for (int i = 0; i < n / 2 + 1; i++)
            {
                //down
                for (int j = i; j < n - i; j++)
                {
                    matrix[j, i] = new ColoredElement() { Value = number++, Color = ConsoleColor.Red };
                }

                //right
                for (int j = i + 1; j < n - i; j++)
                {
                    matrix[n - i - 1, j] = new ColoredElement() { Value = number++, Color = ConsoleColor.Yellow };
                }

                //up
                for (int j = (int)n - i - 2; j >= i; j--)
                {
                    matrix[j, n - 1 - i] = new ColoredElement() { Value = number++, Color = ConsoleColor.Green };
                }

                //left
                for (int j = n - i - 2; j >= i + 1; j--)
                {
                    matrix[i, j] = new ColoredElement() { Value = number++, Color = ConsoleColor.White };
                }
            }
        }

        private static void PrintMatrix(ColoredElement[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.ForegroundColor = matrix[i, j].Color;
                    Console.Write("{0,3}", matrix[i, j].Value);
                }
                Console.WriteLine();
            }
        }
    }
}
