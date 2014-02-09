namespace _10.FindsSeqWithGivenSum
{
    using System;
    using System.Text;
    class FindsSeqWithGivenSum
    {
        //10.Write a program that finds in given array of integers a sequence of given sum S (if present).
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
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
            //Console.WriteLine("Enter first array numbers");

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

            //Console.Write("Enter sum: ");
            //int givenSum = 0;
            //while (!int.TryParse(Console.ReadLine(), out givenSum))
            //{
            //    Console.Write("Enter valid sum: ");
            //}
            #endregion

            int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            int givenSum = 8,
                currentSum = 0;

            int seqStart = 0;
            int seqEnd = 0;
            bool isSumFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum == givenSum)
                    {
                        seqStart = i;
                        seqEnd = j;
                        isSumFound = true;
                        break;
                    }
                }
                if (isSumFound)
                {
                    break;
                }

                currentSum = 0;
            }

            StringBuilder output = new StringBuilder();

            if (isSumFound)
            {
                for (int i = seqStart; i <= seqEnd; i++)
                {
                    output.AppendFormat("{0} + ", array[i]);
                }

                output.Length -= 2;
                output.AppendFormat("= {0}", givenSum);
            }
            else
            {
                output.Append("The given sum not present in the array.");
            }
           

            Console.WriteLine(output.ToString());
        }
    }
}
