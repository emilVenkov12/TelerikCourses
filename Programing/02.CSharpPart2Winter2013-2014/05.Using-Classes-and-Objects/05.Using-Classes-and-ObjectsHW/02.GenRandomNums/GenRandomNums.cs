namespace _02.GenRandomNums
{
    using System;

    class GenRandomNums
    {
        //02.Write a program that generates and prints to the console 10 random values in the range [100, 200].

        static void Main()
        {
            int lowBound = 100,
                highBound = 200;
            int randomNumsCount = 10;
            Random randGen = new Random();

            for (int i = 0; i < randomNumsCount; i++)
			{
                Console.WriteLine("{0}", randGen.Next(lowBound, highBound + 1));
			}
        }
    }
}
