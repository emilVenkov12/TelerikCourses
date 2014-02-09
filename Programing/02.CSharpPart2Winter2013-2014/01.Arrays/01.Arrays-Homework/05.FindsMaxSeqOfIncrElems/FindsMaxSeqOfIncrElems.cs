namespace _05.FindsMaxSeqOfIncrElems
{
    using System;
    class FindsMaxSeqOfIncrElems
    {
        //05.Write a program that finds the maximal increasing sequence in an array.
        //Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter array numbers count: ");
            //int arrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out arrayLenght) || arrayLenght < 1)
            //{
            //    Console.Write("Enter valid array numbers count: ");
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Enter only integer numbers!");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("Enter array numbers");

            //int[] array = new int[arrayLenght];
            //for (int i = 0; i < arrayLenght; i++)
            //{
            //    int number = 0;
            //    Console.Write("Enter {0}-th number:", i + 1);
            //    while (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.Write("Enter valid {0}-th number:", i + 1);
            //    }
            //    array[i] = number;
            //}

            #endregion

            int[] array = new int[] { 3, 2, 3, 4, 2, 3, 4, 5 };

            int startIndex = 0,
                endIndex = 0;
            int seqLenght = 1;
            int maxSeqLenght = 1,
                maxStartIndex = 0,
                maxEndIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1]) // the only diff with prev task
                {
                    if (seqLenght > maxSeqLenght)
                    {
                        maxSeqLenght = seqLenght;
                        maxStartIndex = startIndex;
                        maxEndIndex = endIndex;
                    }
                    startIndex = i;
                    endIndex = i;
                    seqLenght = 1;
                }
                else
                {
                    endIndex = i;
                    seqLenght++;
                }
            }

            if (seqLenght > maxSeqLenght)
            {
                maxSeqLenght = seqLenght;
                maxStartIndex = startIndex;
                maxEndIndex = endIndex;
            }


            for (int i = maxStartIndex; i <= maxEndIndex; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
        }
    }
}
