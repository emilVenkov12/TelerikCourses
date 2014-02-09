using System;

class PrintShapedMatrix
{
    //11.Write a program that reads from the console a positive integer
    //number N (N < 20) and outputs a matrix like the following:

    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0 || n > 19)
        {
            Console.Write("Enter N (N > 0): ");
        }

        for (uint i = 1; i <= n; i++)
        {
            for (uint j = i; j <= n + i -1; j++)
            {
                Console.Write("{0,3} ", j);
            }
            Console.WriteLine();
        }
    }
}

