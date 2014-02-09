namespace _14.QuickSortNumbers
{
    using System;

    class QuickSortNumbers
    {
        //14.Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter array numbers count: ");
            //int arrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out arrayLenght) || arrayLenght < 1)
            //{
            //    Console.Write("Enter valid array numbers count: ");
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Enter only integer numbers!");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("Enter first array numbers");

            //int[] array = new int[arrayLenght];
            //for (int i = 0; i < arrayLenght; i++)
            //{
            //    int number = 0;
            //    Console.Write("Enter {0}-th number:", i + 1);
            //    while (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.Write("Enter valid {0}-th number:", i + 1);
            //    }
            //    array[i] = number;
            //}

            #endregion

            int[] array = new int[] { 1, 2, 3 };
            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine(String.Join(", ", array));
        }

        static void Swap(int[] array, int firstNumIndex, int secNumIndex)
        {
            int temp = array[firstNumIndex];
            array[firstNumIndex] = array[secNumIndex];
            array[secNumIndex] = temp;
        }

        static int Partition(int[] array, int low, int high)
        {
            //Swap(array, new Random().Next(low, high + 1), high);
            int left = low;

            int right = high - 1;

            int pivot = array[high];

            while (right > left)
            {
                while (array[left] <= pivot && left < right)
                {
                    left++;
                }
                while (array[right] >= pivot && right > left)
                {
                    right--;
                }
                if (left == right)
                {
                    break;
                }
                Swap(array, left++, right--);
            }

            // Swap(array, high, right);
            if (array[right] > pivot)
            {
                Swap(array, high, right);
            }

            return right;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int splitIndex = Partition(array, low, high);

            QuickSort(array, low, splitIndex - 1);
            QuickSort(array, splitIndex + 1, high);
        }
    }
}
