namespace _09.FindsMostFrequentNum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindsMostFrequentNum
    {
        //09.Write a program that finds the most frequent number in an array. Example:
	    //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

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

            int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 1, 4, 1, 3 };

            Dictionary<int, int> numsFrequence = new Dictionary<int,int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (numsFrequence.ContainsKey(array[i]))
                {
                    numsFrequence[array[i]]++;
                }
                else
                {
                    numsFrequence.Add(array[i], 1);
                }
            }
            var result = numsFrequence.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Console.WriteLine("{0} -> {1} times.",result.Key, result.Value );

        }
    }
}
