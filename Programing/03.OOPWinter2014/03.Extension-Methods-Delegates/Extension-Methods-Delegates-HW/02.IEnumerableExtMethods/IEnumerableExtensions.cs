using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IEnumerableExtMethods
{
    public static class IEnumerableExtensions
    {
        private static void IsValid<T>(IEnumerable<T> items) where T : IComparable<T>
        {
            if (items == null)
            {
                throw new ArgumentNullException("items", "Value cannot be null.");
            }
            if (!items.Any<T>())
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }
        }

        public static T Max<T>(this IEnumerable<T> items) where T : IComparable<T> 
        {
            IsValid<T>(items);
            System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
            enumerator.MoveNext();

            T max = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(max) > 0)
                {
                    max = enumerator.Current;
                }
            }

            return max;
        }

        public static T Min<T>(this IEnumerable<T> items) where T : IComparable<T>
        {
            IsValid(items);
            System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
            enumerator.MoveNext();

            T min = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(min) < 0)
                {
                    min = enumerator.Current;
                }
            }

            return min;
        }

        public static T Sum<T>(this IEnumerable<T> items) where T : struct, IComparable<T>
        {
            IsValid(items);
            System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
            enumerator.MoveNext();

            dynamic sum = enumerator.Current;

            while (enumerator.MoveNext())
            {
                sum+= enumerator.Current;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> items) where T : struct, IComparable<T>
        {
            IsValid(items);
            System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
            enumerator.MoveNext();

            dynamic product = enumerator.Current;

            while (enumerator.MoveNext())
            {
                product *= enumerator.Current;
            }

            return product;
        }

        public static double Avarage<T>(this IEnumerable<T> items) where T : struct, IComparable<T>
        {
            IsValid(items);
            System.Collections.Generic.IEnumerator<T> enumerator = items.GetEnumerator();
            enumerator.MoveNext();

            double count = 1;

            while (enumerator.MoveNext())
            {
                count++;
            }

            return (dynamic)items.Sum() / count;
        }
    }
}
