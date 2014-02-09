using System;

class CheckIfNumIsPrime
{
    //07.Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
    //E.g. 37 is prime.

    static void Main()
    {
        //Console.Write("Enter positive integer nummber: ");
        //uint number = 0;
        //while (!uint.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.Write("Enter a valid positive integer number!: ");
        //}

        uint number = 29,
            divider = 2;
        bool isPrime = true;

        while (divider <= Math.Sqrt(number))
        {
            if (number % divider == 0)
            {
                isPrime = false;
                break;
            }
            divider++;
        }

        Console.WriteLine("The number {0} is {1}.", number, isPrime ? "prime" : "not prime");
    }
}

