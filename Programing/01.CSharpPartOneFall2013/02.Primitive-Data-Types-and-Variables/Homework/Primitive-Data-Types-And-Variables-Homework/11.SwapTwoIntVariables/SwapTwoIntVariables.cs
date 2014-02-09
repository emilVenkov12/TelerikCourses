using System;

class SwapTwoIntVariables
{
    //11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

    static void Main()
    {
        //Uncommetn this to enter values through console input
        //Console.Write("Enter first number: ");
        //int firstNum = int.Parse(Console.ReadLine());


        //Console.Write("Enter second number: ");
        //int secondNum = int.Parse(Console.ReadLine());

        int firstNum = 5;
        int secondNum = 10;

        Console.WriteLine("Before swap firstNum = {0}, secondNum = {1}", firstNum, secondNum);

        firstNum = firstNum + secondNum;
        secondNum = firstNum - secondNum;
        firstNum = firstNum - secondNum;

        //Variant with third variable
        //int thirdVariable = firstNum;
        //firstNum = secondNum;
        //secondNum = thirdVariable;

        Console.WriteLine("After swap firstNum = {0}, secondNum = {1}", firstNum, secondNum);

    }
}
