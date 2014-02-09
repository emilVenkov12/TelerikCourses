namespace _06.FindsKElemsWithMaxSum
{
    using System;
    class FindsKElemsWithMaxSum
    {
        //06.Write a program that reads two integer numbers N and K and an array of N elements from the console. 
        //Find in the array those K elements that have maximal sum.

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

            //Console.Write("Enter K: ");
            //int k = 0;
            //while (!int.TryParse(Console.ReadLine(), out k) || k < 1 || k > array.Length)
            //{
            //    Console.Write("Enter valid K (1 <= k <= array lenght) : ");
            //}

            #endregion

            int k = 10;
            int[] array = new int[] { -2, 0, -1, -2, -3, -3, -2, -2, -2, -2 };
            int sum = 0,
                maxSum = int.MinValue,
                maxIndex = 0;
            for (int i = 0; i < k; i++)
            {
                sum += array[i]; 
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }

            for (int i = k ; i < array.Length; i++)
            {
                sum -= array[i - k];
                sum += array[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i - k + 1;
                }
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                maxIndex = array.Length - k + 1;
            }

            for (int i = maxIndex; i < maxIndex + k; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
        }
    }
}
