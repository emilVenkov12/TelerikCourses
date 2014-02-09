namespace _14.MinMaxAndMoreMethods
{
    using System;

    class MinMaxAndMoreMethods
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sequence: {0}", String.Join(", ", numbers));
            Console.WriteLine("Min : {0}", Min(numbers));
            Console.WriteLine("Max : {0}", Max(numbers));
            Console.WriteLine("Sum : {0}", Sum(numbers));
            Console.WriteLine("Average : {0}", Average(numbers));
            Console.WriteLine("Product : {0}", Product(numbers));
        }

        static int Min(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        static int Max(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        static long Sum(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static double Average(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            return Sum(numbers) / (double)numbers.Length;
        }

        static long Product(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            long product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
