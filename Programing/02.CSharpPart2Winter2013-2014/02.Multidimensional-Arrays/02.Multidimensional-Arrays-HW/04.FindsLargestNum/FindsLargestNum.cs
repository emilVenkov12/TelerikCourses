namespace _04.FindsLargestNum
{
    using System;

    class FindsLargestNum
    {

        //04.Write a program, that reads from the console an array of N integers and an integer K,
        //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is  ≤ K. 

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
            //Console.WriteLine("Enter array numbers");

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
            //Console.Write("Enter K: ");
            //int k = 0;
            //while (!int.TryParse(Console.ReadLine(), out k))
            //{
            //    Console.Write("Enter valid K: ");
            //}
            #endregion

            int[] array = new int[] { 1, -2, 3, -4, 5, -6, 7, -8 };

            int k = -9;

            Array.Sort(array);

            Console.WriteLine("Sorted array: {0}", String.Join(", ", array));

            int kIndex = Array.BinarySearch(array, k);

            if (array[0] > k)
            {
                Console.WriteLine("No element <= k");
            }
            else if (kIndex < 0)
            {
                kIndex = ~kIndex;
                kIndex = kIndex == 0 ? 0 : kIndex - 1;

                Console.WriteLine("Element <= K is {0} at index {1}", array[kIndex], kIndex);
            }
            else
            {
                Console.WriteLine("Found at index {0}.", kIndex);
            }
        }
    }
}
