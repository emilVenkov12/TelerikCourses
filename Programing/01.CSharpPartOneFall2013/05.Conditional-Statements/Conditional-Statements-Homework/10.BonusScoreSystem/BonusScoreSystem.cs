using System;

class BonusScoreSystem
{
    //10. Write a program that applies bonus scores to given scores in the range [1..9].
    //The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
    //if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
    //If it is zero or if the value is not a digit, the program must report an error.
	//Use a switch statement and at the end print the calculated new value in the console.

    static void Main()
    {
        Console.Write("Enter digit [1..9]: ");
        uint digit = 0;
        while (!uint.TryParse(Console.ReadLine(), out digit) || digit <= 0 || digit > 9)
        {
            Console.Write("Enter valid digit [1..9]: ");
        }

        uint result = digit;

        switch (digit)
        {
            case 1: result *= 10; break;
            case 2: result *= 10; break;
            case 3: result *= 10; break;
            case 4: result *= 100; break;
            case 5: result *= 100; break;
            case 6: result *= 100; break;
            case 7: result *= 1000; break;
            case 8: result *= 1000; break;
            case 9: result *= 1000; break;
        }
        Console.WriteLine("Score: {0}", result);
    }
}
