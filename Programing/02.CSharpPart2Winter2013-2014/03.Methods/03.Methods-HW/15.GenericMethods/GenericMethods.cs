namespace _15.GenericMethods
{
    using System;

    class GenericMethods
    {
        //15.* Modify your last program and try to make it work for any number type, 
        //not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

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

        static T Min<T>(params T[] numbers) where T : IComparable<T>
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            T min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i].CompareTo(min) < 0)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        static T Max<T>(params T[] numbers) where T : IComparable<T>
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            T max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i].CompareTo(max) > 0)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        static T Sum<T>(params T[] numbers) where T : IComparable<T>
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            dynamic sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static double Average<T>(params T[] numbers) where T : IComparable<T>
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            return Convert.ToDouble(Sum(numbers)) / numbers.Length;
        }

        static T Product<T>(params T[] numbers) where T : IComparable<T>
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("numbers");
            }
            if (numbers.Length == 0)
            {
                throw new ArgumentException("The length of the sequence should be greater than zero.");
            }

            dynamic product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
