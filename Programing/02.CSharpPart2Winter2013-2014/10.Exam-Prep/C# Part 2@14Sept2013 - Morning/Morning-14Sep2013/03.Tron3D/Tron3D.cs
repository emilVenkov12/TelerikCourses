namespace _03.Tron3D
{
    using System;
    using System.Linq;

    class Tron3D
    {
        static void Main()
        {
            int[] xyz = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[,] field = new char[xyz[0] + 1, 2 * xyz[1] + 2 * xyz[2]];
            //

            int[,] directions = 
            {
                {1, 0}, //Down
                {0, -1}, //Left
                {-1, 0}, //Up
                {0, 1}//Right
            };

            string redPlayerMoves = Console.ReadLine();
            string bluePlayerMoves = Console.ReadLine();

            int pathLength = 0, redPlDir = 3, bluePlDir = 1;
            bool isRedPlAlive = true,
                isBluePlAlive = true;
            //bool toMoveRed = true,
            //    toMoveBlue = true;

            int redRow = (xyz[0] + 1) / 2,
                redCol = xyz[1] / 2,
                blueRow = redRow,
                blueCol = (xyz[1] + xyz[2] - 1) + (xyz[1] / 2);

            string winner = "DRAW";

            for (int redInd = 0, blueInd = 0; redInd < redPlayerMoves.Length || blueCol < bluePlayerMoves.Length;redInd++, blueInd++)
            {
                field[redRow, redCol] = 'E';
                field[blueRow, blueCol] = 'B';

                if (redPlayerMoves[redInd] == 'L')
                {
                    redPlDir--;
                    redInd--;
                    //toMoveRed = false;
                }
                else if (redPlayerMoves[redInd] == 'R')
                {
                    redPlDir++;
                    redInd--;
                    //toMoveRed = false;
                }

                if (bluePlayerMoves[blueInd] == 'L')
                {
                    bluePlDir--;
                    blueInd--;
                    //toMoveBlue = false;
                }
                else if (bluePlayerMoves[blueInd] == 'R')
                {
                    bluePlDir++;
                    blueInd--;
                    //toMoveBlue = false;
                }

                if (bluePlDir < 0)
                {
                    //ble
                }
                //if (toMoveRed)
                //{
                redRow += directions[redPlDir, 0];
                redCol += directions[redPlDir, 1];
                //}

                #region Check Red Bounds

                if (redRow < 0 || redRow > field.GetLength(0))
                {
                    isRedPlAlive = false;
                    winner = "BLUE";
                    break;
                }
                if (redCol < 0)
                {
                    redCol = field.GetLength(1) - 1;
                }
                if (redCol >= field.GetLength(1))
                {
                    redCol = 0;
                }

                #endregion

                //if (toMoveRed)
                //{
                if (field[redRow, redCol] != '\0')
                {
                    isRedPlAlive = false;
                }
                //}

                //if (toMoveBlue)
                //{
                blueRow += directions[bluePlDir, 0];
                blueCol += directions[bluePlDir, 1];
                //}


                #region Check Blue Bunds

                if (blueRow < 0 || blueRow >= field.GetLength(0))
                {
                    isBluePlAlive = false;
                    winner = "RED";
                    break;
                }
                if (blueCol < 0)
                {
                    blueCol = field.GetLength(1) - 1;
                }
                if (blueCol >= field.GetLength(1))
                {
                    blueCol = 0;
                }

                #endregion
                //if (toMoveBlue)
                //{
                if (field[blueRow, blueCol] != '\0')
                {
                    isBluePlAlive = false;
                }
                //}


                if (!isRedPlAlive && !isBluePlAlive)
                {
                    winner = "DRAW";
                    break;
                }
                else if (!isBluePlAlive)
                {
                    winner = "RED";
                    break;
                }
                else if (!isRedPlAlive)
                {
                    winner = "BLUE";
                    break;
                }
            }

            pathLength = Math.Abs(((xyz[0] + 1) / 2) - redRow) + Math.Abs(redCol - xyz[1] / 2);

            Console.WriteLine(winner);
            Console.WriteLine(pathLength);
        }
    }
}
