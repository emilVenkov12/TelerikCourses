namespace _05.OneTaskIsNotEnough
{
    using System;

    class OneTaskIsNotEnough
    {
        static void Main()
        {
            int lampsCount = int.Parse(Console.ReadLine());
            string firstCommands = Console.ReadLine();
            string secondCommands = Console.ReadLine();

            int lastTurnOffLamp = GetLastTurnedOffLamp(lampsCount);
            string robotOneState = GetRobotState(firstCommands);
            string robotTwoState = GetRobotState(secondCommands);
            Console.WriteLine(lastTurnOffLamp);
            Console.WriteLine(robotOneState);
            Console.WriteLine(robotTwoState);
        }

        private static string GetRobotState(string commands)
        {
            int[,] directions = 
            {
                {0, 1}, //up
                {1, 0}, //right
                {0, -1}, //down
                {-1, 0}, //left

            };

            int curDir = 0;
            int x = 0, y = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < commands.Length; i++)
                {
                    if (commands[i] == 'S')
                    {
                        x += directions[curDir, 0];
                        y += directions[curDir, 1];
                    }
                    else if (commands[i] == 'L')
                    {
                        curDir--;
                        curDir += 4;
                        curDir %= 4;
                    }
                    else
                    {
                        curDir++;
                        curDir %= 4;
                    }
                }
            }

            if (x == 0 && y == 0)
            {
                return "bounded";
            }
            else
            {
                return "unbounded";
            }
            
        }

        private static int GetLastTurnedOffLamp(int lampsCount)
        {
            int[] lamps = new int[lampsCount + 1];
            bool[] lampsToTurnOn = new bool[lampsCount + 1];

            for (int i = 1; i <= lampsCount; i++)
            {
                lamps[i] = i;
            }

            int step = 1,
                lampsLeft = lampsCount;
            while (lampsLeft > 1)
            {
                step++;

                Array.Clear(lampsToTurnOn, 1, lampsLeft);

                for (int i = 1; i <= lampsLeft; i += step)
                {
                    lampsToTurnOn[i] = true;
                }

                int newLampsLeft = 0;

                for (int i = 1; i <= lampsLeft; i ++)
                {
                    if (!lampsToTurnOn[i])
                    {
                        newLampsLeft++;
                        lamps[newLampsLeft] = lamps[i];
                    }
                }
                lampsLeft = newLampsLeft;
            }
            return lamps[1];
        }
    }
}
