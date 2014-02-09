namespace _03.Brackets
{
    using System;
    using System.Linq;

    class Brackets
    {
        static void Main()
        {
            string brackets = Console.ReadLine();
            int expLenght = brackets.Length;
            long[,] dp = new long[expLenght + 1, expLenght + 2];
            dp[0, 0] = 1;
            for (int i = 1; i <= expLenght; i++)
            {
                if (brackets[i - 1] == '(')
                {
                    dp[i, 0] = 0;
                }
                else
                {
                    dp[i, 0] = dp[i - 1, 1];
                }
                for (int j = 1; j <= expLenght; j++)
                {
                    if (brackets[i - 1] == '(')
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else if (brackets[i - 1] == ')')
                    {
                        dp[i, j] = dp[i - 1, j + 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j + 1] + dp[i - 1, j - 1];
                    }
                }
            }

            Console.WriteLine(dp[expLenght, 0]);
        }
    }
}
