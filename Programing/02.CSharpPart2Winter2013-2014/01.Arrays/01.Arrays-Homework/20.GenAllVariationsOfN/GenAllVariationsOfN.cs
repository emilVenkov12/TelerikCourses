namespace _20.GenAllVariationsOfN
{
    using System;
    class GenAllVariationsOfN
    {
        //20.Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
        //Example:	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

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

            int N = 3,
                K = 2;
            int [] arr = new int[K];
            GenVariation(arr, 0, N);
        }

        private static void GenVariation(int[] arr, int p, int N)
        {
            if (p >= arr.Length)
            {
                PrintArray(arr);
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                arr[p] = i;
                GenVariation(arr, p + 1, N);
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
