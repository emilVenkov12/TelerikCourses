using System;
using System.Numerics;

class PrintsFirst100FibonacciMembers
{
    static void Main()
    {
        int membersCount = 100;

        BigInteger a = 0, b = 1, c = 0;

        while (membersCount > 0)
        {
            a += b;
            Console.WriteLine(a);
            b = c;
            c = a;
            membersCount--;
        }
    }
}
