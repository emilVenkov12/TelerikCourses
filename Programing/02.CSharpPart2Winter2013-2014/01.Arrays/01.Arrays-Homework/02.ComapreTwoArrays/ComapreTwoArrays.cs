namespace _02.ComapreTwoArrays
{
    using System;
    using System.Linq;
    class ComapreTwoArrays
    {
        //02.Write a program that reads two arrays from the console and compares them element by element.

        static void Main()
        {
            #region Read first array

            Console.Write("Enter first array numbers count: ");
            int firstArrayLenght = 0;
            while (!int.TryParse(Console.ReadLine(), out firstArrayLenght) || firstArrayLenght < 1)
            {
                Console.Write("Enter valid first array numbers count: ");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter only integer numbers!");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter first array numbers");

            int[] firstArray = new int[firstArrayLenght];
            for (int i = 0; i < firstArrayLenght; i++)
            {
                int number = 0;
                Console.Write("Enter {0}-th number:", i + 1);
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Enter valid {0}-th number:", i + 1);
                }
                firstArray[i] = number;
            }

            #endregion

            #region Read second array
            Console.WriteLine();
            Console.Write("Enter second array numbers count: ");
            int secondArrayLenght = 0;
            while (!int.TryParse(Console.ReadLine(), out secondArrayLenght) || secondArrayLenght < 1)
            {
                Console.Write("Enter valid second array numbers count: ");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter only integer numbers!");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter second array numbers");

            int[] secondArray = new int[secondArrayLenght];
            for (int i = 0; i < secondArrayLenght; i++)
            {
                int number = 0;
                Console.Write("Enter {0}-th number:", i + 1);
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Enter valid {0}-th number:", i + 1);
                }
                secondArray[i] = number;
            }

            #endregion

            #region Comparing
            if (firstArrayLenght == secondArrayLenght)
            {
                bool isArrayEqual = true;
                for (int i = 0; i < firstArrayLenght; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        isArrayEqual = false;
                        break;
                    }
                }
                Console.WriteLine();
                if (isArrayEqual)
                {
                    Console.WriteLine("The arrays are equal.");
                }
                else
                {
                    Console.WriteLine("The arrays are not equal.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The arrays are with different lengths, therefore are not equal.");
            } 
            #endregion


            //Shorten version
            //Console.WriteLine("Are the array equal? - {0}", Enumerable.SequenceEqual(firstArray, secondArray));
        }
    }
}
