namespace _17.FindsGivenSubsetSumOfKElems
{
    using System;
    using System.Text;
    class FindsGivenSubsetSumOfKElems
    {
        //17.* Write a program that reads three integer numbers N, K and S and 
        //an array of N elements from the console. Find in the array a subset 
        //of K elements that have sum S or indicate about its absence.

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter numbers count: ");
            //uint numbersCount = 0;
            //while (!uint.TryParse(Console.ReadLine(), out numbersCount) || numbersCount <= 0)
            //{
            //    Console.Write("Enter valid numbers count: ");
            //}

            //int[] numbers = new int[numbersCount];

            //for (uint i = 0; i < numbersCount; i++)
            //{
            //    Console.Write("Enter {0}-th number: ", i + 1);
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.Write("Enter valid {0}-th number: ", i + 1);
            //    }
            //}

            //Console.Write("Enter sum to search: ");
            //int givenSum = 0;
            //while (!int.TryParse(Console.ReadLine(), out givenSum))
            //{
            //    Console.Write("Enter valid sum: ");
            //}

            //Console.Write("Enter K: ");
            //int K = 0;
            //while (!int.TryParse(Console.ReadLine(), out K) || K < 1 || K >= numbersCount)
            //{
            //    Console.Write("Enter valid K: ");
            //}


            #endregion


            int[] numbers = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            int givenSum = 14;
            int K = 4;
            bool isSumFound = false;

            for (int i = 1; i < Math.Pow(2, numbers.Length); i++)
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

                if (tempSum == givenSum && GetOnesCount(bits) == K)
                {
                    isSumFound = true;
                    for (int j = 0; j < bits.Length; j++)
                    {
                        int bit = int.Parse(bits[j].ToString());
                        if (bit == 1)
                        {
                            outputSum.Append(String.Format("{0} + ", numbers[numbers.Length - bits.Length + j]));
                        }
                    }
                    outputSum.Length -= 2;
                    outputSum.AppendFormat("= {0}", givenSum);
                    Console.WriteLine(outputSum.ToString());
                }
            }

            if (!isSumFound)
            {
                Console.WriteLine("Such sum don't present in the given array.");
            }
        }

        static int GetOnesCount(string bits)
        {
            int onesCount = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    onesCount++;
                }
            }

            return onesCount;
        }
    }
}
