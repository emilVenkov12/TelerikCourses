using System;
using System.Linq;

class BullsAndCows
{
    static void Main()
    {
        string number = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());
        bool solutionFound = false;
        const char used = '#';

        for (int guesNumber = 1000; guesNumber <= 9999; guesNumber++)
        {
            char[] guesNumberDigits = guesNumber.ToString().ToCharArray();
            char[] numberDigits = number.ToCharArray();
            bool isHasZero = false;

            for (int i = 0; i < guesNumberDigits.Length; i++)
            {
                if (guesNumberDigits[i] == '0')
                {
                    isHasZero = true;
                    break;
                }
            }

            if (!isHasZero)
            {
                int bullsCount = GetBullsCount(ref numberDigits, ref guesNumberDigits, used);
                int cowsCount = GetCowsCount(ref numberDigits, ref guesNumberDigits, used);

                if (bullsCount == targetBulls && cowsCount == targetCows)
                {
                    solutionFound = true;
                    Console.Write("{0} ", guesNumber);
                }
            }            
        }

        if (!solutionFound)
        {
            Console.Write("No");
        }
    }

    private static int GetBullsCount(ref char[] numberDigits, ref char[] guesNumberDigits, char used)
    {
        int bullsCount = 0;
        for (int i = 0; i < guesNumberDigits.Length; i++)
        {
            if (guesNumberDigits[i] == numberDigits[i])
            {
                bullsCount++;
                guesNumberDigits[i] = used;
                numberDigits[i] = used;
            }
        }

        return bullsCount;
    }

    private static int GetCowsCount(ref char[] numberDigits, ref char[] guesNumberDigits, char used)
    {
        int cowsCount = 0;

        for (int i = 0; i < guesNumberDigits.Length; i++)
        {
            for (int j = 0; j < numberDigits.Length; j++)
            {
                if (numberDigits[j] == guesNumberDigits[i] && guesNumberDigits[i] != used)
                {
                    cowsCount++;
                    numberDigits[j] = used;
                    guesNumberDigits[i] = used;
                }
            }
        }

        return cowsCount;
    }

}
