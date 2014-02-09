using System;

class PrintsAllDeckCards
{
    //10.Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
    //The cards should be printed with their English names. Use nested for loops and switch-case.
    static void Main()
    {
        string[] cardsPaints = new string[] { "♠", "♥", "♦", "♣" };
        string[] cardsFaces = new string[] { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };

        foreach (var cardPaint in cardsPaints)
        {
            foreach (var cardFace in cardsFaces)
            {
                Console.WriteLine("{0}{1}",cardFace, cardPaint);
            }
            Console.WriteLine();
        }
    }
}
