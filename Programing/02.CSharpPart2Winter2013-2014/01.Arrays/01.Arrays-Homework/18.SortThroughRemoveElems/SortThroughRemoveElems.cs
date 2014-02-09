namespace _18.SortThroughRemoveElems
{
    using System;
    using System.Collections.Generic;
    class SortThroughRemoveElems
    {
        //18.* Write a program that reads an array of integers and removes from it a 
        //minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	    //{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

        static void Main()
        {
            #region Manual Input

            //Console.Write("Enter numbers count: ");
            //int count = 0;
            //while (!int.TryParse(Console.ReadLine(), out count) || count < 1)
            //{
            //    Console.Write("Enter valid numbers count: ");
            //}

            //int[] numbers = new int[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Enter {0}-th number: ", i + 1);
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.Write("Enter valid {0}-th number: ", i + 1);
            //    }
            //}

            #endregion

            int[] numbers = new int[] { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

            int[] lengths = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if ((numbers[i] >= numbers[j]) && (lengths[j] > max))
                    {
                        max = lengths[j];
                    }
                }
                lengths[i] = 1 + max;
            }

            int prevIndex = 0, maxLength = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (lengths[i] > maxLength)
                {
                    maxLength = lengths[i];
                    prevIndex = i;
                }
            }

            List<int> sequence = new List<int>();
            sequence.Add(numbers[prevIndex]);
            for (int i = prevIndex - 1; i >= 0; i--)
            {
                if ((lengths[i] == lengths[prevIndex] - 1)
                    && (numbers[i] <= numbers[prevIndex]))
                {
                    sequence.Add(numbers[i]);
                    prevIndex = i;
                }
            }

            for (int i = sequence.Count - 1; i >= 0; i--)
            {
                Console.Write("{0} ", sequence[i]);
            }
        }
    }
}
