namespace _06.SecretLanguage
{
    using System;
    using System.Linq;
    using System.Text;

    class SecretLanguage
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();

            int wordsCount = int.Parse(Console.ReadLine());

            string[] words = Console.ReadLine().Split(' ');

            char[][] sortedWords = new char[wordsCount][];

            for (int i = 0; i < wordsCount; i++)
            {
                sortedWords[i] = words[i].ToCharArray();
                Array.Sort(sortedWords[i]);
            }

            int[] dp = new int[inputWord.Length + 1];
            dp[0] = 0;
            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = 100000;
            }

            //StringBuilder currSeq = new StringBuilder();
            char[] inputChars = inputWord.ToCharArray();

            for (int i = 1; i <= inputWord.Length; i++)
            {
                for (int j = 0; j < sortedWords.Length; j++)
                {
                    if (sortedWords[j].Length <= i)
                    {
                        int wordLength = sortedWords[j].Length;
                        Array.Sort(inputChars, i - wordLength, i);
                        bool isEqual = true;

                        for (int k = wordLength - 1; k >= 0; k--)
                        {
                            if (sortedWords[j][k] != inputChars[i - wordLength + k])
                            {
                                isEqual = false;
                                break;
                            }

                        }
                        if (isEqual)
                        {
                            int cost = 0;

                            for (int k = wordLength - 1; k >= 0; k--)
                            {
                                if (words[j][k] != inputWord[i - wordLength + k])
                                {
                                    cost++;
                                }

                            }

                            if (i - wordLength >= 0)
                            {
                                cost += dp[i - wordLength];
                            }

                            if (dp[i] > cost)
                            {
                                dp[i] = cost;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(dp[dp.Length - 1] != 100000 ? dp[dp.Length -1] : -1);
        }
    }
}
