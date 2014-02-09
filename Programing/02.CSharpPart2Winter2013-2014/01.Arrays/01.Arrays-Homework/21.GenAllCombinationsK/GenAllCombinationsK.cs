namespace _21.GenAllCombinationsK
{
    using System;
    class GenAllCombinationsK
    {
        //21.Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
        //Example:	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

        static void Main(string[] args)
        {
            #region Manual input

            //Console.Write("Enter N: ");
            //int N = 0;
            //while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
            //{
            //    Console.Write("Enter valid N: ");
            //}

            //Console.Write("Enter K: ");
            //int K = 0;
            //while (!int.TryParse(Console.ReadLine(), out K) || K < 1)
            //{
            //    Console.Write("Enter valid K: ");
            //}

            #endregion

            int N = 5,
                K = 2;
            int[] arr = new int[K];
            GenVariation(arr, 0, N, 1);
        }

        private static void GenVariation(int[] arr, int p, int N, int startFrom)
        {
            if (p >= arr.Length)
            {
                PrintArray(arr);
                return;
            }

            for (int i = startFrom; i <= N; i++)
            {
                arr[p] = i;
                GenVariation(arr, p + 1, N, i +1);
            }
        }

        private static void PrintArray(int[] arr)
        {
            Console.Write("{");
            Console.Write("{0}", String.Join(", ", arr));
            Console.Write("}, ");
        }
    }
}
