namespace _10.FactorialsOfNums1To100
{
    using System;
    using System.Collections.Generic;

    class FactorialsOfNums1To100
    {
        //10.Write a program to calculate n! for each n in the range [1..100]. 
        //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

        static void Main()
        {
            int[][] result = GetFactorialsTo(1000); //for 1000 elements takes about 10 sec - TODO: try to make it faster

            for (int i = 0; i < result.Length; i++)
            {
                Array.Reverse(result[i]);
                Console.WriteLine("{0}! = {1}", i + 1, String.Join(String.Empty, result[i]));
            }
        }

        static int[][] GetFactorialsTo(int maxNumber)
        {
            int[][] result = new int[maxNumber][];
            result[0] = new int[] { 1 };
            for (int i = 1; i < maxNumber; i++)
            {
                result[i] = MultiplyArray(result[i - 1], NumberToArray(i + 1));
            }

            return result;
        }

        static int[] NumberToArray(int number)
        {
            List<int> result = new List<int>();

            while (number != 0)
            {
                result.Add(number % 10);
                number /= 10;
            }

            return result.ToArray();
        }
        static int[] MultiplyArray(int[] firstArray, int[] secArray)
        {
            int[] result = new int[] { 0 };

            int carry = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                List<int> tempResult = new List<int>();

                tempResult.AddRange(new int[i]); // ofset

                for (int j = 0; j < secArray.Length; j++)
                {
                    int tempProduct = (firstArray[i] * secArray[j]) + carry;
                    carry = tempProduct / 10;
                    tempResult.Add(tempProduct % 10);
                }
                if (carry > 0)
                {
                    tempResult.Add(carry);
                    carry = 0;
                }
                result = AddArrays(result, tempResult.ToArray());
            }

            return result;
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
