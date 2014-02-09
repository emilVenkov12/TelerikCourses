using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        string stringN = Console.ReadLine();
        char[] nDigits = stringN.ToCharArray();
        stringN = "";
        for (int i = 0; i < nDigits.Length; i++)
        {
            if (nDigits[i] != '.' && nDigits[i] != '-')
            {
                stringN += nDigits[i];
            }
        }
        BigInteger n = BigInteger.Parse(stringN);
        while (n > 9)
        {
            BigInteger sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }
        Console.WriteLine(n);
    }
}