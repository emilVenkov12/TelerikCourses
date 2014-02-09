using System;

class FormulaBit1
{
    static void Main()
    {
        int gridSize = 8;
        string[] grid = new string[gridSize];

        for (int i = 0; i < gridSize; i++)
        {
            grid[i] = Convert.ToString(byte.Parse(Console.ReadLine()),2).PadLeft(8,'0');
        }
        char[] directions = new char[] { 'D', 'L', 'U', 'L' };
        int currentDir = 0, prevDir = 4; // possiblle are D(down),L(left), U(up)

        int turnCount = 0, trackLenght = 0;
        int row = 0, col = 7;
        bool isFinishReached = false;

        if (grid[0][7] == '0')
        {
            trackLenght++;

            while (true)
            {
                if (directions[currentDir] == 'D')
                {
                    row++;
                }
                else if (directions[currentDir] == 'L')
                {
                    col--;
                }
                else if (directions[currentDir] == 'U')
                {
                    row--;
                }
                if (row >= 0 && row < gridSize &&
                    col >= 0 && col < gridSize &&
                    grid[row][col] == '0')
                {
                    trackLenght++;
                    if (row == 7 && col == 0)
                    {
                        isFinishReached = true;
                        break;
                    }
                }
                else
                {
                    if (directions[currentDir] == 'D')
                    {
                        row--;
                        if (col - 1 >= 0 && grid[row][col - 1] == '0')
                        {
                            prevDir = currentDir;
                            currentDir = 1;
                            turnCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (directions[currentDir] == 'L')
                    {
                        col++;
                        if (row - 1 >= 0 && grid[row - 1][col] == '0' && prevDir == 0)
                        {
                            prevDir = currentDir;
                            currentDir = 2;
                            turnCount++;
                        }
                        else if (row + 1 < gridSize && grid[row + 1][col] == '0' && prevDir == 2)
                        {
                            prevDir = currentDir;
                            currentDir = 0;
                            turnCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (directions[currentDir] == 'U')
                    {
                        row++;
                        if (col - 1 >= 0 && grid[row][col - 1] == '0')
                        {
                            prevDir = currentDir;
                            currentDir = 1;
                            turnCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
        if (isFinishReached)
        {
            Console.WriteLine("{0} {1}", trackLenght, turnCount);
        }
        else
        {
            Console.WriteLine("No {0}", trackLenght);
        }
        //PrintGrid(grid);
        
    }
    static void PrintGrid(string[] grid)
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            Console.WriteLine(grid[i]); ;
        }
    }
}