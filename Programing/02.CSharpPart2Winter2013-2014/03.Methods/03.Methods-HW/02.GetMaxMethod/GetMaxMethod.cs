namespace _02.GetMaxMethod
{
    using System;

    class GetMaxMethod
    {
        //02.Write a method GetMax() with two parameters that returns the bigger of two integers. 
        //Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

        static void Main()
        {
            #region Manual Input

            //int firstNum = 0;
            //Console.Write("Enter first number: ");

            //while (!int.TryParse(Console.ReadLine(), out firstNum))
            //{
            //    Console.Write("Enter valid first number: ");
            //}

            //int secNum = 0;
            //Console.Write("Enter second number: ");

            //while (!int.TryParse(Console.ReadLine(), out secNum))
            //{
            //    Console.Write("Enter valid second number: ");
            //}

            //int thirdNum = 0;
            //Console.Write("Enter third number: ");

            //while (!int.TryParse(Console.ReadLine(), out thirdNum))
            //{
            //    Console.Write("Enter valid third number: ");
            //}

            #endregion

            int firstNum = 1, secNum = 2, thirdNum = 3;
            Console.WriteLine("Max of {0}, {1}, {2} is {3}", 
                firstNum, secNum, thirdNum, GetMax(GetMax(firstNum, secNum), thirdNum));
        }

        static int GetMax(int firstNum, int secondNum)
        {
            return firstNum > secondNum ? firstNum : secondNum;
        }
    }
}
