namespace _07.SelectionSortArray
{
    using System;
    class SelectionSortArray
    {
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

            int[] array = new int[] { 0, 5, 2, 6, 9, 3, 1, 4, 8, 0 };

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = GetMinElemIndex(array, i);
                if (array[i] != array[minIndex])
                {
                    SwapElements(ref array, i, minIndex);
                }
            }

            Console.WriteLine(String.Join(", ", array));
        }

        static void SwapElements(ref int[] array, int firstElemIndex, int secondElemIndex)
        {
            int temp = array[firstElemIndex];
            array[firstElemIndex] = array[secondElemIndex];
            array[secondElemIndex] = temp;
        }

        static int GetMinElemIndex(int[] array, int startIndex = 0)
        {
            int minIndex = startIndex;
            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}
