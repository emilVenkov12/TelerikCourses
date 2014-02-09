namespace _19.GenAllPermutations
{
    using System;
    class GenAllPermutations
    {
        //19.* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
        //Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

        static void Main()
        {

            int rightBound = int.Parse(Console.ReadLine()),
                leftBound = 1;
            int[] numbers = new int[rightBound - leftBound + 1];

            for (int i = 0, number = leftBound; number <= rightBound; i++, number++)
            {
                numbers[i] = number;
            }
            PrintPermutation(numbers);
            int swapIndex = 0, counter = 1;
            while (counter < (rightBound * (rightBound - 1)))
            {
                swapIndex = 0;
                while (swapIndex != numbers.Length - 1)
                {
                    SwapInt(ref numbers[swapIndex], ref numbers[swapIndex + 1]);
                    if (counter < (rightBound * (rightBound - 1)))
                    {
                        PrintPermutation(numbers);
                    }
                    swapIndex++;
                    counter++;
                }
            }
        }

        static void PrintPermutation(int[] numbers)
        {
            Console.Write("{");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
        }

        static void SwapInt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
