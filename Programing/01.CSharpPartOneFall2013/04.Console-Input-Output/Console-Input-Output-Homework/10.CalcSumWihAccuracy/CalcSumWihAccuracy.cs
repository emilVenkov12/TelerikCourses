using System;

class CalcSumWihAccuracy
{
    static void Main()
    {
        double sum = 1, prevSum = 0;
        double i = 2;
        while (Math.Abs(sum - prevSum) > 0.001)
        {
            prevSum = sum;
            if (i % 2 == 0)
            {
                sum = sum + (1 / i);
            }
            else
            {
                sum = sum - (1 / i);
            }
            i++;
        }

        Console.WriteLine(sum);   
    }
}

