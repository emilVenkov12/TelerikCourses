using System;

class CalcNthCatalanNumber
{
    //09.Write a program to calculate the Nth Catalan number by given N.

    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Enter N (N > 0): ");
        }

        ulong nFact = 1;

        for (uint i = 2; i <= n; i++)
        {
            nFact *= i;
        }

        ulong douleNFact = nFact;

        for (ulong i = n + 1; i <= 2*n; i++)
        {
            douleNFact *= i;
        }

        ulong catalanNumber = douleNFact / (nFact * (nFact * (n + 1)));

        Console.WriteLine("The {0}th catalan number is {1}", n, catalanNumber);
    }
}
