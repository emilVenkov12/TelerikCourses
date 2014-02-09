using System;

class CalcTrailingZeros
{
    //12.* Write a program that calculates for given N how many trailing zeros present at the end of the number N!.
    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = 0;
        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Enter N (N > 0): ");
        }

        uint fiveDivisors = 0;
       
        while (n > 0)
        {
            n /= 5;
            fiveDivisors++;
        }

        Console.WriteLine("The number of trailling zeros is {0}", fiveDivisors);
    }
}