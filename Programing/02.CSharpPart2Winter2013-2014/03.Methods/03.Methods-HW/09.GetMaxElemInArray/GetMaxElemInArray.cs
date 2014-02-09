namespace _09.GetMaxElemInArray
{
    using System;

    class GetMaxElemInArray
    {
        //09.Write a method that return the maximal element in a portion of array of integers 
        //starting at given index. Using it write another method that sorts an array in ascending / descending order.

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter array numbers count: ");
            //int arrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out arrayLenght)  || arrayLenght < 1)
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

            int[] array = { 1, 24, 2, 3, 3, 3, 4, 3, 4, 12, 25 };

            SortArray(array);
            Console.WriteLine("Sorted array: {0}",String.Join(", ", array));

            SortArray(array, false);
            Console.WriteLine("Sorted descending array: {0}", String.Join(", ", array));
        }

        static int GetMaxElemIndex(int[] array, int startIndex = 0)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (startIndex < 0 || startIndex >= array.Length)
            {
                throw new ArgumentException("Start index should be in bounds of the array.");
            }

            int maxElemIndex = startIndex;

            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i] >= array[maxElemIndex])
                {
                    maxElemIndex = i;
                }
            }

            return maxElemIndex;
        }

        static void SortArray(int[] array, bool isAscending = true)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            for (int i = 0; i < array.Length; i++)
            {
                Swap(array, i, GetMaxElemIndex(array, i));
            }

            if (isAscending)
            {
                Array.Reverse(array);
            }
        }

        static void Swap(int[] array, int x, int y)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (x < 0 || x >= array.Length)
            {
                throw new ArgumentException("The index x should be in bounds of the array.");
            }

            if (y < 0 || y >= array.Length)
            {
                throw new ArgumentException("The index y should be in bounds of the array.");
            }

            if (x != y)
            {
                int temp = array[x];
                array[x] = array[y];
                array[y] = temp;
            }

        }
    }
}
