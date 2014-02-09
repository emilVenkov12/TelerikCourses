using System;
using System.Text;

class TheSecretsOfNumbers
{
    static void Main()
    {
        string strNum = Console.ReadLine();
        long secretSum = CalcSecretSum(strNum.TrimStart(new char[] { '-' }));
        Console.WriteLine(secretSum);
        if (secretSum % 10 == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", strNum);
        }
        else
        {
            string alphaSeq = CalcAlpheSeq(secretSum);
            Console.WriteLine(alphaSeq);
        }
    }

    private static string CalcAlpheSeq(long secretSum)
    {
        long remainder = secretSum % 26;
        long lettersCount = secretSum % 10;

        StringBuilder result = new StringBuilder();
        char letter = (char)(remainder + 64 + 1);

        for (int i = 0; i < lettersCount; i++)
        {
            result.Append(letter.ToString());
            letter++;
            if (letter > 'Z')
            {
                letter = 'A';
            }
        }

        return result.ToString();
    }
    //It takes string because the input number can have 400 digits o_O
    static long CalcSecretSum(string strNum)
    {
        long result = 0;
        int digitPos = strNum.Length;
        //3 7
        for (int i = 0; i < strNum.Length; i++)
        {
            int digit = int.Parse(strNum[i].ToString());

            if (digitPos % 2 == 0)
            {
                result += (digit * digit) * digitPos;
            }
            else
            {
                result += digit * digitPos * digitPos;
            }

            digitPos--;
        }

        return result;
    }
}