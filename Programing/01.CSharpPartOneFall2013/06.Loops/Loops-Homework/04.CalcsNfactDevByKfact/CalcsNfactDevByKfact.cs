using System;

class CalcsNfactDevByKfact
{
    //04.Write a program that calculates N!/K! for given N and K (1<K<N).

    static void Main()
    {
        Console.Write("Enter K: ");
        uint k = 0;
        while (!uint.TryParse(Console.ReadLine(), out k) || k < 2)
        {
            Console.Write("Enter K (1<K<N): ");
        }

        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n) || n <= k)
        {
            Console.Write("Enter n (1<K<N): ");
        }

        ulong result = 1;

        for (uint i = n - k; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine("{0}!/{1}! = {2}", k, n, result);
    }
}
