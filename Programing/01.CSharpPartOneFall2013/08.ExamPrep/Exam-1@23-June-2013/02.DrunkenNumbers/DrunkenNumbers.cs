using System;

class DrunkenNumbers
{
    static void Main()
    {
        int roundsCount = int.Parse(Console.ReadLine());
        int firstPlayerPoints = 0,
            secondPlayerPoints = 0;

        for (int i = 0; i < roundsCount; i++)
        {
            string drunkenNumber = Console.ReadLine().TrimStart(new char[] { '0', '-' });
            if (drunkenNumber.Length == 0)
            {
                drunkenNumber = "0";
            }

            for (int j = 0; j < drunkenNumber.Length / 2; j++)
            {
                firstPlayerPoints += int.Parse(drunkenNumber[j].ToString());
            }

            for (int j = drunkenNumber.Length / 2; j < drunkenNumber.Length; j++)
            {
                secondPlayerPoints += int.Parse(drunkenNumber[j].ToString());
            }

            if (drunkenNumber.Length % 2 == 1)
            {
                firstPlayerPoints += int.Parse(drunkenNumber[drunkenNumber.Length / 2].ToString());
            }
        }

        if (firstPlayerPoints > secondPlayerPoints)
        {
            Console.WriteLine("M {0}", Math.Abs(firstPlayerPoints - secondPlayerPoints));
        }
        else if (firstPlayerPoints < secondPlayerPoints)
        {
            Console.WriteLine("V {0}", Math.Abs(firstPlayerPoints - secondPlayerPoints));
        }
        else
        {
            Console.WriteLine("No {0}", firstPlayerPoints + secondPlayerPoints);
        }
    }
}

