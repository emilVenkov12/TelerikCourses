namespace _04.GetNumAppearsCountMethod
{
    using System;
    using System.Linq;

    class GetNumAppearsCountMethod
    {
        //04.Write a method that counts how many times given number appears in given array.
        //Write a test program to check if the method is working correctly.

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter array numbers count: ");
            //int arrayLenght = 0;
            //while (!int.TryParse(Console.ReadLine(), out arrayLenght)  || arrayLenght < 1)
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

            //Console.Write("Enter number to search count apperians: ");
            //int number = 0;
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Enter valid number: ");
            //}

            #endregion

            int[] array = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int number = 2;

            Console.WriteLine("The appears count of {0} in {1} is {2}",
                number, String.Join(", ", array), GetApperiansCount(array, number));

        }

        static int GetApperiansCount(int[] array, int number)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }

            //shorter version
            //count = array.Count(x => x == number);

            return count;
        }
    }
}
