namespace _01.AllocatesArrayOfIntegers
{
    using System;
    class AllocatesArrayOfIntegers
    {
        //01.Write a program that allocates array of 20 integers and initializes each
        //element by its index multiplied by 5. Print the obtained array on the console.

        static void Main()
        {
            int integersCount = 20,
                number = 5;
            int[] arrayOfIntegers = new int[integersCount];

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                arrayOfIntegers[i] = i * number;
                Console.WriteLine(arrayOfIntegers[i]);
            }
        }
    }
}
