namespace _05.TwoIsBetterThanOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TwoIsBetterThanOne
    {
        static void Main()
        {
            var inputBounds = Console.ReadLine().Split(' ');

            int luckyNums = GetLuckyNumsCount(long.Parse(inputBounds[0]), long.Parse(inputBounds[1]));
            int taskTwo = Task2(Console.ReadLine().Split(',').Select(int.Parse).ToArray(), int.Parse(Console.ReadLine()));
            Console.WriteLine(luckyNums);
            Console.WriteLine(taskTwo);

            //Console.WriteLine(GetLuckyNumsCount(1, 99));
            //GetCombination(new List<int> { 3, 5, 5, 3 });
        }

        static int Task2(int[] numbers, int percent)
        {
            Array.Sort(numbers);

            return numbers[(int)(numbers.Length * (percent / 100.01))];
        }

        static bool IsPalindrome(long number)
        {
            string strNum = number.ToString();
            for (int i = 0; i < strNum.Length / 2; i++)
            {
                if (strNum[i] != strNum[strNum.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static int GetLuckyNumsCount(long lowerBound, long upperBound)
        {
            var numbers = new List<long> { 3, 5 };
            int left = 0;

            while (left < numbers.Count)
            {
                int right = numbers.Count;
                for (int i = left; i < right; i++)
                {
                    if (numbers[i] <= upperBound)
                    {
                        numbers.Add((numbers[i] * 10) + 3);
                        numbers.Add((numbers[i] * 10) + 5);
                    }
                }

                left = right;
            }
            int count = 0;
            foreach (var num in numbers)
            {
                if (num >= lowerBound &&  num <= upperBound && IsPalindrome(num))
                {
                    count++;
                }
            }
            return count;
        }

    }
}
