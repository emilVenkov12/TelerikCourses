namespace _03.CompareTwoCharArrays
{
    using System;
    class CompareTwoCharArrays
    {
        //03.Write a program that compares two char arrays lexicographically (letter by letter).

        static void Main()
        {
            #region Read first array

            Console.Write("Enter first array letters count: ");
            int firstArrayLenght = 0;
            while (!int.TryParse(Console.ReadLine(), out firstArrayLenght) || firstArrayLenght < 1)
            {
                Console.Write("Enter valid first array letters count: ");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter only letters");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter first array letters");

            char[] firstArray = new char[firstArrayLenght];
            for (int i = 0; i < firstArrayLenght; i++)
            {
                char character = new char();
                Console.Write("Enter {0}-th letter:", i + 1);
                while (!char.TryParse(Console.ReadLine(), out character) || !char.IsLetter(character))
                {
                    Console.Write("Enter valid {0}-th letter: ", i + 1);
                }
                firstArray[i] = character;
            }

            #endregion

            #region Read second array

            Console.WriteLine();
            Console.Write("Enter second array letters count: ");
            int secondArrayLenght = 0;
            while (!int.TryParse(Console.ReadLine(), out secondArrayLenght) || secondArrayLenght < 1)
            {
                Console.Write("Enter valid second array letters count: ");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter only letters!");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter second array numbers");

            char[] secondArray = new char[secondArrayLenght];
            for (int i = 0; i < secondArrayLenght; i++)
            {
                char character = new char();
                Console.Write("Enter {0}-th letter:", i + 1);
                while (!char.TryParse(Console.ReadLine(), out character) || !char.IsLetter(character))
                {
                    Console.Write("Enter valid {0}-th letter: ", i + 1);
                }
                secondArray[i] = character;
            }

            #endregion

            #region Comparing
            int shorterLenght = Math.Min(firstArrayLenght, secondArrayLenght);

            bool isResultFound = false;

            for (int i = 0; i < shorterLenght; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is lexicographically earlier");
                    isResultFound = true;
                    break;
                }
                else if (secondArray[i] < firstArray[i])
                {
                    isResultFound = true;
                    Console.WriteLine("The second array is lexicographically earlier");
                    break;
                }
            }
            if (!isResultFound)
            {
                if (firstArrayLenght < secondArrayLenght)
                {
                    Console.WriteLine("The first array is lexicographically earlier");
                }
                else if (secondArrayLenght < firstArrayLenght)
                {
                    Console.WriteLine("The second array is lexicographically earlier");
                }
                else
                {
                    Console.WriteLine("The arrays are equal.");
                }
            }
            #endregion
        }
    }
}
