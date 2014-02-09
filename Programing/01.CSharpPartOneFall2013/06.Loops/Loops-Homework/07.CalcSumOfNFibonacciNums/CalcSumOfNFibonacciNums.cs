using System;
using System.Numerics;

class CalcSumOfNFibonacciNums
{
    //07.Write a program that reads a number N and calculates the sum of the 
    //first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
    //Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

    static void Main()
    {
        Console.Write("Enter members count: ");
        uint membersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out membersCount) || membersCount == 0)
        {
            Console.Write("Enter valid members count: ");
        }

        BigInteger a = 0, b = 1, c = 0, sum = 0;

        while (membersCount > 0)
        {
            a += b;
            sum += a;
            b = c;
            c = a;
            membersCount--;
        }
        Console.WriteLine("The sum of the members is {0}", sum);
    }
}
