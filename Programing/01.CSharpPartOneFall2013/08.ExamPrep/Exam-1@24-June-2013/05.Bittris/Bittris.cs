using System;
using System.Text.RegularExpressions;
using System.Linq;

class Bittris
{
    static void Main()
    {

        //IDEAS: board to be one integer number
        //to have 4 constatnts, each with 8 bit each row: 255, 65280, 16711680, 4278190080
        //whit their help to clean row, or take row value to check if row is full with ones
        //no idea how to implement the moving on the next row, maybe through using masks, set values of group of bits? 
        //collision check board & shape << offset (24, 16, 8, 0)
        //convert from b base to n base

        int rowsCount = int.Parse(Console.ReadLine());

        Regex regex = new Regex("f");
        int board = 0;
        long playerScore = 0;

        PrintBoard(board);

        for (int i = 0; i < rowsCount / 4; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            int curretNumberScore = GetOnesBitCount(currentNumber);

            string commands = Console.ReadLine() + Console.ReadLine() + Console.ReadLine();

            int offset = 28;
            //check for collison on first row
            if ((board & (currentNumber << offset)) == 0)
            {
                for (int j = 0; j < commands.Length; j++)
                {
                    if (commands[j] == 'L')
                    {
                        //check if number will leave borders
                        offset++;
                    }
                    else if (commands[j] == 'R')
                    {
                        offset--;
                    }

                    if ((board & (currentNumber << offset - 4)) == 0) // check if can go down
                    {
                        offset -= 4;
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine();
                    PrintBoard(board | (currentNumber << offset - 4));

                }
                board |= currentNumber << offset;

                Console.WriteLine();
                PrintBoard(board);

            }
            else
            {
                Console.WriteLine(playerScore);
                break;
            }
        }

        Console.WriteLine();
        PrintBoard(board);

        //move element left
        //currentNumber = currentNumber << 1;

        //move element down
        //currentNumber = currentNumber << (initialOffset - 4);
        //add element to the borad
        //board |= currentNumber;

        //PrintBoard(board);
        //Console.WriteLine(GetOnesBitCount(1));
        //string num = regex.Replace(Convert.ToString(currentNumber, 16),"");
        //currentNumber = Convert.ToInt32(num, 16);
        //Console.WriteLine();
        //PrintBoard(currentNumber);
    }
    static void PrintBoard(int board)
    {
        string boardToBinary = Convert.ToString(board, 2).PadLeft(32, '0');


        for (int i = 0; i < boardToBinary.Length; i++)
        {
            Console.Write(boardToBinary[i]);
            if ((i + 1) % 8 == 0 && i != 0)
            {
                Console.WriteLine();
            }
        }
    }

    static int GetOnesBitCount(int number)
    {
        int count = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((number & (1 << i)) != 0)
            {
                count++;
            }
        }
        return count;
    }
}
