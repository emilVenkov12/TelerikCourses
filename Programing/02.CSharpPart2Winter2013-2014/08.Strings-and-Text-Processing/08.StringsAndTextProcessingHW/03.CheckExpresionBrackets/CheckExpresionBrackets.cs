namespace _03.CheckExpresionBrackets
{
    using System;
    using System.Collections.Generic;

    class CheckExpresionBrackets
    {
        //03.Write a program to check if in a given expression the brackets are put correctly.
        //Example of correct expression: ((a+b)/5-d).
        //Example of incorrect expression: )(a+b)).

        static void Main()
        {
            #region Manual input

            //Console.Write("Enter expression: ");
            //string exp = Console.ReadLine();

            #endregion

            string expression = "(a + b / 5 - d";
            int stack = 0;
            
            for (int i = 0; i < expression.Length && stack >= 0; i++)
            {
                if (expression[i] == '(')
                {
                    stack++;
                }
                else if (expression[i] == ')')
                {
                    stack--;
                }
            }

            if (stack == 0)
            {
                Console.WriteLine("Correct expression.");
            }
            else
            {
                Console.WriteLine("Incorrect expression.");
            }
        }
    }
}
