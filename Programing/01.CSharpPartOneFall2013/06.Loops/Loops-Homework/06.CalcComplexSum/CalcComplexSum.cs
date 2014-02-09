using System;

class CalcComplexSum
{
    //06.Write a program that, for a given two integer numbers N and X, 
    //calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.Write("Enter N (N > 0): ");
        }

        Console.Write("Enter X: ");
        int x = 0;
        while (!int.TryParse(Console.ReadLine(), out x) || x == 0)
        {
            Console.Write("Enter X (should be not equal to zero): ");
        }

        double sum = 1;
        long denom = x;
        ulong nFact = 1;
        for (uint i = 2; i <= n + 1; i++)
        {
            sum += ((double)nFact) / denom;
            denom *= x;
            nFact *= i;
        }

        Console.WriteLine(sum);
    }
}
