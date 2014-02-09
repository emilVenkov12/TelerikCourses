namespace _05.SortsStringArrayByItsElemLenghts
{
    using System;
    using System.Linq;

    class SortsStringArrayByItsElemLenghts
    {
        //05.You are given an array of strings. Write a method that sorts the array by 
        //the length of its elements (the number of characters composing them).

        static void Main()
        {
            #region Manual Input

            //Console.Write("Enter array strings count: ");
            //int arrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out arrayLenght) || arrayLenght < 1)
            //{
            //    Console.Write("Enter valid array strings count: ");
            //}

            //string[] array = new string[arrayLenght];
            //for (int i = 0; i < arrayLenght; i++)
            //{
            //    Console.Write("Enter array[{0}] string: ", i);

            //    string str = Console.ReadLine();

            //    while (!str.All(char.IsLetter) || String.IsNullOrEmpty(str))
            //    {
            //        Console.Write("Enter valid array[{0}] string: ", i);
            //        str = Console.ReadLine();
            //    }
            //    array[i] = str;
            //}

            #endregion

            string[] array = new string[] { "dssssssssss", "a", "b", "aa", "rrqw", "rrrrr" };

            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine(String.Join(", ", array));

            //shorter and slower version
            //Console.WriteLine(String.Join(", ", array.OrderBy(x => x.Length)));
        }

        static void Swap(string[] array, int firstNumIndex, int secNumIndex)
        {
            string temp = array[firstNumIndex];
            array[firstNumIndex] = array[secNumIndex];
            array[secNumIndex] = temp;
        }

        static int Partition(string[] array, int low, int high)
        {
            //Swap(array, new Random().Next(low, high + 1), high);
            int left = low;

            int right = high - 1;

            string pivot = array[high];

            while (right > left)
            {
                while (array[left].Length <= pivot.Length && left < right)
                {
                    left++;
                }
                while (array[right].Length >= pivot.Length && right > left)
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
            if (array[right].Length > pivot.Length)
            {
                Swap(array, high, right);
            }

            return right;
        }

        static void QuickSort(string[] array, int low, int high)
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
