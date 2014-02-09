namespace _04.Guitar
{
    using System;
    using System.Linq;

    class Guitar
    {
        static void Main()
        {
            int songsCount = int.Parse(Console.ReadLine());
            int[] volumeChanges = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastVolume = int.Parse(Console.ReadLine());
            int maxVolume = int.Parse(Console.ReadLine());

            bool[,] dp = new bool[songsCount + 1, maxVolume + 1];

            dp[0, lastVolume] = true;

            for (int i = 0, row = 0; i < songsCount; i++, row++)
            {
                int index = IndexOfTrue(row, 0, dp);
                while (index != -1)
                {
                    if (index + volumeChanges[i] <= maxVolume)
                    {
                        dp[row + 1, index + volumeChanges[i]] = true;
                    }
                    if (index - volumeChanges[i] >= 0)
                    {
                        dp[row + 1, index - volumeChanges[i]] = true;
                    }
                    dp[row, index] = false;
                    index = IndexOfTrue(row, index + 1, dp);
                }
            }

            Console.WriteLine(MaxTrueIndex(dp, songsCount));    

        }

        static int IndexOfTrue(int row, int startIndex, bool[,] dp)
        {
            for (int i = startIndex; i < dp.GetLength(1); i++)
            {
                if (dp[row, i] == true)
                {
                    return i;
                }
            }

            return -1;
        }

        static int MaxTrueIndex(bool[,] dp, int row)
        {
            for (int i = dp.GetLength(1) - 1; i >= 0; i--)
            {
                if (dp[row, i] == true)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
