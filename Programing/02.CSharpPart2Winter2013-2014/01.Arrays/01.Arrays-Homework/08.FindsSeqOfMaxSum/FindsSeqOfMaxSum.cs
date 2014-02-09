namespace _08.FindsSeqOfMaxSum
{
    using System;
    using System.Text;
    class FindsSeqOfMaxSum
    {
        //08.Write a program that finds the sequence of maximal sum in given array. Example:
        //	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	    //Can you do it with only one loop (with single scan through the elements of the array)?

        static void Main(string[] args)
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

            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8};

            int currentSum = array[0],
                maxSum = array[0];

            int seqStart = 0;
            int seqStartTemp = 0;
            int seqEnd = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                    seqStartTemp = i;
                }
                else
                {
                    currentSum += array[i];
                }


                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    seqStart = seqStartTemp;
                    seqEnd = i;
                }
            }

            StringBuilder output = new StringBuilder();

            for (int i = seqStart; i <= seqEnd; i++)
            {
                output.AppendFormat("{0} + ", array[i]);
            }

            output.Length -= 2;
            output.AppendFormat("= {0}", maxSum);

            Console.WriteLine(output.ToString());
        }
    }
}
