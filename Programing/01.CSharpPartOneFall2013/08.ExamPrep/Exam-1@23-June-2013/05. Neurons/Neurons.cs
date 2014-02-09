using System;
using System.Text;

class Neurons
{
    static void Main()
    {
        StringBuilder output = new StringBuilder();

        while (true)
        {
            long currentNum = long.Parse(Console.ReadLine());
            if (currentNum == -1)
            {
                break;
            }

            long outputNum = 0;

            for (int bit = 0; bit < 32; bit++)
            {
                int currentBitValue = GetBitValueAt(currentNum, bit);

                if (currentBitValue == 1 && outputNum == 0)
                {
                    bit++;
                    currentBitValue = GetBitValueAt(currentNum, bit);
                    if (currentBitValue == 1)
                    {
                        bit--;
                        continue;
                    }
                    while (currentBitValue != 1)
                    {
                        outputNum = SetBitAtPos(outputNum, bit, 1);
                        bit++;
                        currentBitValue = GetBitValueAt(currentNum, bit);
                        if (bit > 31)
                        {
                            outputNum = 0;
                            break;
                        }
                    }
                }
            }
            output.AppendLine(outputNum.ToString());
        }

        Console.WriteLine(output.ToString());
    }

    static long SetBitAtPos(long number, int pos, int value)
    {
        long result = 0;
        long mask = ((long)1) << pos;
        if (value == 1)
        {
            result = number | mask;
        }
        else if (value == 0)
        {
            result = number & (~mask);
        }

        return result;
    }

    static int GetBitValueAt(long number, int pos)
    {
        long mask = 1l << pos;
        return (number & mask) != 0 ? 1 : 0;
    }
}