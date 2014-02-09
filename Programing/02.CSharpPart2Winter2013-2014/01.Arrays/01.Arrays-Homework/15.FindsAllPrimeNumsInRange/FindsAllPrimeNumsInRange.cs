namespace _15.FindsAllPrimeNumsInRange
{
    using System;
    class FindsAllPrimeNumsInRange
    {
        //15.Write a program that finds all prime numbers in the range [1...10 000 000]. 
        //Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        static void Main(string[] args)
        {
            #region Manual input

            //int leftBorder = 1;
            //Console.Write("Enter right border of the range: ");
            //int rightBorder = 0;
            //while (!int.TryParse(Console.ReadLine(), out rightBorder) || leftBorder >= rightBorder)
            //{
            //    Console.Write("Enter valid right border of the range: ");
            //}

            #endregion
            int leftBorder = 1,
                rightBorder = 1000;

            int[] array = new int[rightBorder];

            int markedField = -1;

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] != markedField)
                {
                    Console.Write("{0}, ", i);
                    for (int j = i + i; j < array.Length; j += i)
                    {
                        array[j] = markedField;
                    }
                }
            }
        }
    }
}
