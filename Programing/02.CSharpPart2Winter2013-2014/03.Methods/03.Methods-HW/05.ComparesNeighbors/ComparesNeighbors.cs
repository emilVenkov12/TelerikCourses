namespace _05.ComparesNeighbors
{
    using System;

    class ComparesNeighbors
    {
        //05.Write a method that checks if the element at given
        //position in given array of integers is bigger than its two neighbors (when such exist).

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

            //Console.Write("Enter index to check its neighbors: ");
            //int index = 0;
            //while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= array.Length)
            //{
            //    Console.Write("Enter valid index: ");
            //}

            #endregion

            int[] array = { 1 , 5, 2, 3, 3, 3, 4, 3, 4, 4, 5 };

            int index = 1;

            Console.WriteLine("Is element at index {0} is bigger than its two neighbors? : {1}", 
                index, IsBiggerThanItsNeighbors(array, index));

        }

        static bool IsBiggerThan(int[] array, int currentElemInd, int otherElemInd)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            if (currentElemInd < 0 || currentElemInd >= array.Length)
            {
                throw new ArgumentException("The index of current element"+
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
