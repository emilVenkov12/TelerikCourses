using System;

class Pillars
{
    static void Main()
    {
        int gridHeight = 8,
            gridWidth = 8;
        char[][] grid = new char[gridHeight][];

        for (int i = 0; i < gridHeight; i++)
        {
            grid[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0').ToCharArray();
        }

        //PrintGrid(grid);        

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                int pillar = j;

                long leftPartOnesCount = 0;
                for (int k = 0; k < j; k++)
                {
                    leftPartOnesCount += CalcOnesCount(k, grid);
                }

                long rightPartOnesCount = 0;
                for (int k = j + 1; k < grid[i].Length; k++)
                {
                    rightPartOnesCount += CalcOnesCount(k, grid);
                }
                if (leftPartOnesCount == rightPartOnesCount)
                {
                    Console.WriteLine(7 - pillar);
                    Console.WriteLine(leftPartOnesCount);
                    return;
                }
            }
        }

        Console.WriteLine("No");
    }
    static void PrintGrid(char[][] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.Write("{0} ", grid[i][j]);
            }
            Console.WriteLine();
        }
    }
    static int CalcOnesCount(int col, char[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            if (grid[i][col] == '1')
            {
                count++;
            }
        }
        return count;
    }
}