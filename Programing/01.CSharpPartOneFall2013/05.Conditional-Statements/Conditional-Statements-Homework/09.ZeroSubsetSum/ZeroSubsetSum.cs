using System;
using System.Text;
using System.Linq;

class ZeroSubsetSum
{
    //09.We are given 5 integer numbers. Write a program that checks
    //if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

    static void Main()
    {
        Console.Write("Enter numbers count: ");
        uint numbersCount = 0;
        while (!uint.TryParse(Console.ReadLine(), out numbersCount) || numbersCount < 0)
        {
            Console.Write("Enter valid numbers count: ");
        }

        int[] numbers = new int[numbersCount];

        for (uint i = 0; i < numbersCount; i++)
        {
            Console.Write("Enter {0}-th number: ", i + 1);
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Enter valid {0}-th number: ", i + 1);
            }
        }

        //Ok here is what is my logic: The all possible combinations are 2 ^ numbersCount - 1 (empty set).
        //So to find this combination i use binary representation of indexer. For intance: Let's say we
        //have these numbers: 1 2 3 -3 -1. If there are in array => array[0] = 1, array[1] = 2 etc. The binary
        //representaion of index will look likes this: 1 = "1", 2 = "10" etc.
        //If we take the indexes of the ones in the representations we will have patern of the all combinations of number.
        //             0 1 2  3  4
        //Exp:array =  1 2 3 -3 -1
        //binaryNum = 6 = "1  1  0" => the sum will be eqaul to 3 + -3 etc.

        for (int i = 1; i < Math.Pow(2, numbersCount); i++)
        {
            string bits = Convert.ToString(i, 2);
            StringBuilder outputSum = new StringBuilder();

            long tempSum = 0;

            for (int j = 0; j < bits.Length; j++)
            {
                int bit = int.Parse(bits[j].ToString());
                if (bit == 1)
                {
                    tempSum += numbers[numbers.Length - bits.Length + j];
                }
            }

            if (tempSum == 0)
            {
                for (int j = 0; j < bits.Length; j++)
                {
                    int bit = int.Parse(bits[j].ToString());
                    if (bit == 1)
                    {
                        outputSum.Append(String.Format("{0} + ", numbers[numbers.Length - bits.Length + j]));
                    }
                }                
                outputSum.Length -= 2;
                outputSum.Append("= 0");
                Console.WriteLine(outputSum.ToString());
            }
        }

    }
}
