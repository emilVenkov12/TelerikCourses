namespace _11.BinarySearchIndexOfElem
{
    using System;

    class BinarySearchIndexOfElem
    {
        //11.Write a program that finds the index of given element in a sorted 
        //array of integers by using the binary search algorithm (find it in Wikipedia).

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

            //Console.Write("Enter element for search: ");
            //int givenElem = 0;
            //while (!int.TryParse(Console.ReadLine(), out givenElem))
            //{
            //    Console.Write("Enter valid element for search: ");
            //}
            #endregion

            int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int givenNum = -8;

            Array.Sort(array);

            int minIndex = 0,
                maxIndex = array.Length - 1;
            int midIndex = minIndex + ((maxIndex - minIndex) / 2); // is defined here, to can print it, if element is found
            bool isKeyFound = false;

            while (maxIndex >= minIndex)
            {
                midIndex = minIndex + ((maxIndex - minIndex) / 2);
                if (array[midIndex] == givenNum)
                {
                    isKeyFound = true;
                    break;
                }
                else if (array[midIndex] > givenNum)
                {
                    maxIndex = midIndex - 1;
                }
                else if (array[midIndex] < givenNum)
                {
                    minIndex = minIndex + 1;
                }
            }
            if (isKeyFound)
            {
                Console.WriteLine("The index of {0} is {1}",givenNum, midIndex);
            }
            else
            {
                Console.WriteLine("Element is not present in the array.");
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
