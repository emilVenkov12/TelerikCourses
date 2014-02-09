namespace _02.SuperSum
{
    using System;
    using System.Linq;

    class SuperSum
    {
        static long[,] sumMemoization;
        static int maxK = 14;
        static int maxN = 14;

        static void Main()
        {
            long[] kn = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            sumMemoization = new long[maxK + 1, maxN + 1];
            for (int i = 0; i < sumMemoization.GetLength(0); i++)
            {
                for (int j = 0; j < sumMemoization.GetLength(1); j++)
                {
                    sumMemoization[i, j] = -1;
                }
            }
            Console.WriteLine(Sum(kn[0], kn[1]));
        }

        private static long Sum(long k, long n)
        {
            if (k == 0)
                return n;
            if (sumMemoization[k, n] != -1)
                return sumMemoization[k, n];
            long sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Sum(k - 1, i);
            }

            sumMemoization[k, n] = sum;

            return sum;
        }
    }
}
