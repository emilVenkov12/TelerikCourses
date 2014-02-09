namespace _05.ThreeInOne
{
    using System;
    using System.Linq;

    class ThreeInOne
    {
        static void Main()
        {
            //1
            int[] playersPoints = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int winner = GetBlackJackWinner(playersPoints);

            //2
            int[] sizes = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int friendsCount = int.Parse(Console.ReadLine());

            int bitesSum = GetBitesSum(sizes, friendsCount);

            //3
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] currState = input.Take(3).ToArray();
            int[] targetState = input.Skip(3).Take(3).ToArray();

            int minTranfers = GetMinTransfersCount(currState, targetState);
            Console.WriteLine(winner);
            Console.WriteLine(bitesSum);
            Console.WriteLine(minTranfers);
        }

        private static int GetMinTransfersCount(int[] currState, int[] targetState)
        {
            const int GOLD = 0;
            const int SILVER = 1;
            const int BRONZE = 2;
            int operationCount = 0;


            while (true)
            {
                while (currState[SILVER] < targetState[SILVER])
                {
                    if (currState[GOLD] > targetState[GOLD])
                    {
                        TrasferGoldToSilver(currState);
                        operationCount++;
                    }
                    else if (currState[BRONZE] - 11 >= targetState[BRONZE])
                    {
                        TrasferBronzeToSilver(currState);
                        operationCount++;
                    }
                    else
                    {
                        return -1; //not enough money
                    }
                }

                while (currState[BRONZE] < targetState[BRONZE])
                {
                    if (currState[SILVER] > targetState[SILVER])
                    {
                        TrasferSilverToBronze(currState);
                        operationCount++;
                    }
                    else if (currState[GOLD] > targetState[GOLD])
                    {
                        TrasferGoldToSilver(currState);
                        operationCount++;
                        continue;
                    }
                    else
                    {
                        return -1; //not enough money
                    }
                }

                while (currState[GOLD] < targetState[GOLD])
                {
                    if (currState[SILVER] - 11 >= targetState[SILVER])
                    {
                        TrasferSilverToGold(currState);
                        operationCount++;
                    }
                    else if (currState[BRONZE] - 11 >= targetState[BRONZE])
                    {
                        TrasferBronzeToSilver(currState);
                        operationCount++;
                        continue;
                    }
                    else
                    {
                        return -1;
                    }
                }

                if (currState[BRONZE] >= targetState[BRONZE] 
                        && currState[SILVER] >= targetState[SILVER] 
                        && currState[GOLD] >= targetState[GOLD])
                {
                    return operationCount;
                }
            }
        }

        private static void TrasferSilverToGold(int[] currState)
        {
            currState[1] -= 11;
            currState[0] += 1;
        }

        private static void TrasferSilverToBronze(int[] currState)
        {
            currState[1] -= 1;
            currState[2] += 9;
        }

        private static void TrasferBronzeToSilver(int[] currState)
        {
            currState[2] -= 11;
            currState[1] += 1;
        }

        private static void TrasferGoldToSilver(int[] currState)
        {
            currState[0] -= 1;
            currState[1] += 9;
        }

        static int GetBlackJackWinner(int[] playersPoints)
        {
            //Array.Sort(playersPoints);
            var newSec = playersPoints.Where(x => x <= 21);
            int maxNum = 0;
            if (newSec.Count() > 1)
            {
                maxNum = newSec.Max();
            }
            else
            {
                return -1;
            }

            int maxNumCount = playersPoints.Count(x => x == maxNum);

            if (maxNumCount == 1)
            {
                return Array.IndexOf(playersPoints, maxNum);
            }
            else
            {
                return -1;
            }
        }

        static int GetBitesSum(int[] sizes, int friendsCount)
        {
            int sum = 0;
            Array.Sort(sizes);
            friendsCount++;
            for (int i = sizes.Length - 1; i >= 0; i -= friendsCount)
            {
                sum += sizes[i];
            }

            return sum;
        }
    }
}
