namespace _01.Tribonacci
{
    using System;
    using System.Linq;

    class Tribonacci
    {
        static void Main()
        {
            long[] input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long N = input[3];
            if (N < 4)
            {
                Console.WriteLine(input[N - 1]);
            }
            else
            {
                int curN = 3;

                while (curN < N)
                {
                    input[3] = input[0] + input[1] + input[2];
                    input[0] = input[1];
                    input[1] = input[2];
                    input[2] = input[3];
                    curN++;
                }
                Console.WriteLine(input[3]);
            }

        }
    }
}
