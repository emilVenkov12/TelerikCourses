using System;

class CalcComplexFactExp
{
    //05.Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n) || n < 2)
        {
            Console.Write("Enter N (1<N<K): ");
        }

        Console.Write("Enter K: ");
        uint k = 0;
        while (!uint.TryParse(Console.ReadLine(), out k) || k <= n)
        {
            Console.Write("Enter K (1<N<K): ");
        }

        ulong denominator = 1;

        for (uint i = 2; i <= k - n; i++)
        {
            denominator *= i;
        }

        ulong kFactorial = denominator;

        for (uint i = k - n + 1; i <= k; i++)
        {
            kFactorial *= i;
        }

        ulong nFactorial = denominator;

        if (n >= k - n)
        {
            for (uint i = k - n + 1; i <= n; i++)
            {
                nFactorial *= i;
            }
        }
        else
        {
            for (uint i = k - n; i > n; i--)
            {
                nFactorial /= i;
            }
        }
        
        Console.WriteLine("{0}! * {1}!/({0} - {1})! = {2}", n, k, (nFactorial * kFactorial / denominator));
    }
}