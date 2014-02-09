namespace _06.IndexOfElement
{
    using System;

    class IndexOfElement
    {
        //06.Write a method that returns the index of the first element in array that 
        //is bigger than its neighbors, or -1, if there’s no such element.
        //Use the method from the previous exercise.

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

            int[] array = { 1, 5, 2, 3, 3, 3, 4, 3, 4, 4, 5 };

            Console.WriteLine("The index of the first element bigger " + 
                "than its neighbors is {0}", GetIndexOfFirstElement(array));

        }

        static int GetIndexOfFirstElement(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsBiggerThanItsNeighbors(array, i))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static bool IsBiggerThan(int[] array, int currentElemInd, int otherElemInd)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (currentElemInd < 0 || currentElemInd >= array.Length)
            {
                throw new ArgumentException("The index of current element" +
                    " should be in bounds of the array.");
            }

            if (otherElemInd < 0 || otherElemInd >= array.Length)
            {
                throw new ArgumentException("The index of other element" +
                    " should be in bounds of the array.");
            }

            return array[currentElemInd] > array[otherElemInd];
        }

        static bool IsBiggerThanItsNeighbors(int[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentException("The index of the element should be" +
                    " in bounds of the array.");
            }
            //i accept  that if  current element don't have neighbor,he is bigger than him
            //for example : { 1 } - for this array will return true 
            bool isBiggerThanLeft = true,
                isBiggerThanRight = true;

            if (index > 0)
            {
                isBiggerThanLeft = IsBiggerThan(array, index, index - 1);
            }
            if (index < array.Length - 1)
            {
                isBiggerThanRight = IsBiggerThan(array, index, index + 1);
            }

            return isBiggerThanLeft && isBiggerThanRight;
        }
    }
}
