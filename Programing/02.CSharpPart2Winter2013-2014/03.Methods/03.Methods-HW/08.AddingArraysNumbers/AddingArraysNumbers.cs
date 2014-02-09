namespace _08.AddingArraysNumbers
{
    using System;
    using System.Collections.Generic;

    class AddingArraysNumbers
    {
        //08.Write a method that adds two positive integer numbers represented
        //as arrays of digits (each array element arr[i] contains a digit; the last 
        //digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

        static void Main()
        {
            #region Manual Input

            //Console.Write("Enter first array numbers count: ");
            //int firstArrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out firstArrayLenght) || firstArrayLenght < 1)
            //{
            //    Console.Write("Enter valid first array numbers count: ");
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Enter only integer numbers!");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("Enter first array numbers");

            //int[] firstArray = new int[firstArrayLenght];
            //for (int i = 0; i < firstArrayLenght; i++)
            //{
            //    int number = 0;
            //    Console.Write("Enter {0}-th number:", i + 1);
            //    while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            //    {
            //        Console.Write("Enter valid {0}-th number:", i + 1);
            //    }
            //    firstArray[i] = number;
            //}

            //Console.WriteLine();
            //Console.Write("Enter second array numbers count: ");
            //int secondArrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out secondArrayLenght) || secondArrayLenght < 1)
            //{
            //    Console.Write("Enter valid second array numbers count: ");
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Enter only integer numbers!");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("Enter second array numbers");

            //int[] secondArray = new int[secondArrayLenght];
            //for (int i = 0; i < secondArrayLenght; i++)
            //{
            //    int number = 0;
            //    Console.Write("Enter {0}-th number:", i + 1);
            //    while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            //    {
            //        Console.Write("Enter valid {0}-th number:", i + 1);
            //    }
            //    secondArray[i] = number;
            //}

            #endregion

            int[] firstArray = new int[] { 1 };
            int[] secondArray = new int[] { 9, 9 , 9 };

            int[] result = AddArrays(firstArray, secondArray);
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            Array.Reverse(result);
            Console.WriteLine("{0} + {1} = {2}", 
                String.Join(String.Empty, firstArray), 
                String.Join(String.Empty, secondArray),
                String.Join(String.Empty, result));
        }

        static int[] ResizeArray(int[] oldArray, int newSize)
        {
            int[] newArray = new int[oldArray.Length + newSize];

            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }

            return newArray;
        }

        static int[] AddArrays(int[] firstArray, int[] secondArray)
        {
            int[] result = new int[Math.Max(firstArray.Length, secondArray.Length)];

            int carry = 0;

            for (int i = 0; i < result.Length; i++)
            {
                int tempResult = (i < firstArray.Length ? firstArray[i] : 0) +
                    (i < secondArray.Length ? secondArray[i] : 0) +
                    carry;
                carry = tempResult / 10;
                result[i] = tempResult % 10;
            }

            if (carry == 1)
            {
                result = ResizeArray(result, 1);
                result[result.Length - 1] = carry;
            }

            return result;
        }

    }
}
