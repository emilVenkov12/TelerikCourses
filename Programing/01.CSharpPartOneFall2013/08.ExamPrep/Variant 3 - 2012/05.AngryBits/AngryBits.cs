using System;
using System.IO;

class AngryBits
{
    static void Main()
    {
        if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        {
            Console.SetIn(new StreamReader(@"../../../../Variant 3 - 2012 - Tasks\Problem 5\Tests\test.001.in.txt"));
        }
        int fieldHeight = 8;
        int fieldWidth = 16;
        char[][] gameField = new char[fieldHeight][];
        for (int i = 0; i < 8; i++)
        {
            gameField[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2) // convers number to binary
                .PadLeft(fieldWidth, '0')
                .ToCharArray();
        }

        //PrintField(gameField);
        checked
        {

            long score = 0;
            int pigsCount = 0;
            for (int i = 0; i < fieldHeight; i++)
            {
                for (int j = fieldWidth / 2; j < fieldWidth; j++)
                {
                    if (gameField[i][j] == '1')
                    {
                        pigsCount++;
                    }
                }
            }

            int killedPigsCount = 0;

            for (int j = fieldWidth / 2 - 1; j >= 0; j--)
            {
                for (int i = 0; i < fieldHeight; i++)
                {
                    if (gameField[i][j] == '1') //bird found
                    {
                        gameField[i][j] = '0';
                        int birdRow = i,
                            birdCol = j;
                        int directionRow = -1,
                            directionCol = 1;
                        int pathLenght = 0, currentKilledPigsCount = 0;
                        while (true)
                        {
                            birdRow += directionRow;
                            birdCol += directionCol;
                            if (birdRow < 0) // reached top border of the field, bounce
                            {
                                birdRow++;
                                birdCol--;
                                directionRow *= -1;
                                continue;
                            }

                            if (birdRow >= fieldHeight || birdCol >= fieldWidth)
                            {
                                break;
                            }
                            pathLenght++;
                            if (gameField[birdRow][birdCol] == '1') // pig hit
                            {
                                currentKilledPigsCount++;
                                killedPigsCount++;
                                gameField[birdRow][birdCol] = '0';

                                if (birdRow - 1 >= 0 && gameField[birdRow - 1][birdCol] == '1') //up
                                {
                                    
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow - 1][birdCol] = '0';
                                }
                                if (birdRow - 1 >= 0 && birdCol + 1 < fieldWidth && gameField[birdRow - 1][birdCol + 1] == '1') //up-right
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow - 1][birdCol + 1] = '0';
                                }
                                if (birdCol + 1 < fieldWidth && gameField[birdRow][birdCol + 1] == '1') // right
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow][birdCol + 1] = '0';
                                }
                                if (birdRow + 1 < fieldHeight && birdCol + 1 < fieldWidth && gameField[birdRow + 1][birdCol + 1] == '1') //down-right
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow + 1][birdCol + 1] = '0';
                                }
                                if (birdRow + 1 < fieldHeight && gameField[birdRow + 1][birdCol] == '1') //down
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow + 1][birdCol] = '0';
                                }
                                if (birdRow + 1 < fieldHeight && birdCol - 1 >= 0 && gameField[birdRow + 1][birdCol - 1] == '1') //down-left
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow + 1][birdCol - 1] = '0';
                                }
                                if (birdCol - 1 >= 0 && gameField[birdRow][birdCol - 1] == '1') //left
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow][birdCol - 1] = '0';
                                }
                                if (birdCol - 1 >= 0 && birdRow - 1 >= 0 && gameField[birdRow - 1][birdCol - 1] == '1') //up-left
                                {
                                    currentKilledPigsCount++;
                                    killedPigsCount++;
                                    gameField[birdRow - 1][birdCol - 1] = '0';
                                }
                                score += currentKilledPigsCount * pathLenght;
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("{0} {1}", score, pigsCount - killedPigsCount == 0 ? "Yes" : "No");
        }
        //PrintField(gameField);
        //Console.WriteLine();
    }

    static void PrintField(char[][] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field[i].Length; j++)
            {
                Console.Write("{0} ", field[i][j]);
            }
            Console.WriteLine();
        }
    }
}