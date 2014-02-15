namespace _20.CalcSpecialSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CalcSpecialSum
    {
        static void Main()
        {
            double precision = 0.1;

            Console.WriteLine("Sequence: 1 + 1/2 + 1/4 + 1/8 + 1/16 + ... = {0} and precision: {1}", CalcSpecSum(i => 1.0 / Math.Pow(i, 2), precision), precision);
        }

        static double CalcSpecSum(Func<int, double> term, double precision)
        {
            double sum = 0;
            double termPart = 1;
            double prevSum = -1;

            for (int i = 1; Math.Abs(sum - prevSum) > precision; i++)
            {
                termPart = term(i);
                prevSum = sum;
                sum += termPart;
            }

            return sum;
        }
    }
}
