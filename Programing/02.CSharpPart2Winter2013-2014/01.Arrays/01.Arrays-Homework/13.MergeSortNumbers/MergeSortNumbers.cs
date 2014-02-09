namespace _13.MergeSortNumbers
{
    using System;
    class MergeSortNumbers
    {
        //13.* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

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

            #endregion

            int[] array = new int[] { -1, 2, -3, 4, -5, 6, -7 };
            Console.WriteLine(String.Join(", ", MergeSort(array)));
        }

        static int[] MergeArrays(int[] leftArray, int[] rightArray)
        {
            int[] resultArray = new int[leftArray.Length + rightArray.Length];

            int leftArrayIndex = 0,
                rightArrayIndex = 0;

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (leftArrayIndex < leftArray.Length && 
                    (rightArrayIndex >= rightArray.Length || leftArray[leftArrayIndex] <= rightArray[rightArrayIndex]))
                {
                    resultArray[i] = leftArray[leftArrayIndex++];
                }
                else if (rightArrayIndex < rightArray.Length &&
                    (leftArrayIndex >= leftArray.Length || rightArray[rightArrayIndex] <= leftArray[leftArrayIndex]))
                {
                    resultArray[i] = rightArray[rightArrayIndex++];
                }
            }

            return resultArray;
        }

        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int[] leftArray = new int[array.Length / 2];
            int[] rightArray = new int[array.Length - leftArray.Length];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = leftArray.Length, j = 0; i < array.Length; i++, j++)
            {
                rightArray[j] = array[i];
            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            return MergeArrays(leftArray, rightArray);
        }
    }
}
