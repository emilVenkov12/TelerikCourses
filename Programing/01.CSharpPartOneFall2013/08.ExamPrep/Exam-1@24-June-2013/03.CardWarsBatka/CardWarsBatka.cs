using System;
using System.Collections.Generic;
using System.Numerics;

class CardWarsBatka
{
    static int StringToNum(string card)
    {
        int point = 0;
        switch (card)
        {
            case "A": point = 1; break;
            case "10": point = 2; break;
            case "9": point = 3; break;
            case "8": point = 4; break;
            case "7": point = 5; break;
            case "6": point = 6; break;
            case "5": point = 7; break;
            case "4": point = 8; break;
            case "3": point = 9; break;
            case "2": point = 10; break;
            case "J": point = 11; break;
            case "Q": point = 12; break;
            case "K": point = 13; break;
        }
        return point;
    }
    static void Main()
    {
//        using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;
 
//namespace CardWars
//{
//    class Program
//    {
//        static void Main()
//        {
//            int numberOfGames = int.Parse(Console.ReadLine());
//            int firstPlayerScore = 0;
//            int secondPlayerScore = 0;
//            short firstPlayerGamesWon = 0;
//            short secondPlayerGamesWon = 0;
//            BigInteger firstPlayerOverall = 0;
//            BigInteger secondPlayerOverall = 0;
//            List<string> firstPlayerCards = new List<string>();
//            List<string> secondPlayerCards = new List<string>();
//            int count = 0;
//            for (int i = 0; i < numberOfGames; i++)
//            {
//                firstPlayerCards.Add(Console.ReadLine());
//                firstPlayerCards.Add(Console.ReadLine());
//                firstPlayerCards.Add(Console.ReadLine());
//                secondPlayerCards.Add(Console.ReadLine());
//                secondPlayerCards.Add(Console.ReadLine());
//                secondPlayerCards.Add(Console.ReadLine());
 
//                bool firstContains;
//                bool secondContains;
//                string X = "X";
//                firstContains = firstPlayerCards.Contains(X);
//                secondContains = secondPlayerCards.Contains(X);
 
//                if (firstContains == true && secondContains == false)
//                {
//                    Console.WriteLine("X card drawn! Player one wins the match!");
//                    goto Finish;
//                }
//                else if (firstContains == false && secondContains == true)
//                {
//                    Console.WriteLine("X card drawn! Player two wins the match!");
//                    goto Finish;
//                }
//                else
//                {
//                    bool xUsed1 = false;
//                    bool xUsed2 = false;
//                    for (int j = count; j < count + 3; j++)
//                    {
//                        switch (firstPlayerCards[j])
//                        {
//                            case "2": firstPlayerScore += 10; break;
//                            case "3": firstPlayerScore += 9; break;
//                            case "4": firstPlayerScore += 8; break;
//                            case "5": firstPlayerScore += 7; break;
//                            case "6": firstPlayerScore += 6; break;
//                            case "7": firstPlayerScore += 5; break;
//                            case "8": firstPlayerScore += 4; break;
//                            case "9": firstPlayerScore += 3; break;
//                            case "10": firstPlayerScore += 2; break;
//                            case "A": firstPlayerScore += 1; break;
//                            case "J": firstPlayerScore += 11; break;
//                            case "Q": firstPlayerScore += 12; break;
//                            case "K": firstPlayerScore += 13; break;
//                            case "Z": firstPlayerOverall *= 2; break;
//                            case "Y": firstPlayerOverall -= 200; break;
//                            case "X": if (xUsed1 == false){
//                                firstPlayerOverall += 50;xUsed1 = true ;}; break;
//                        }
//                        switch (secondPlayerCards[j])
//                        {
//                            case "2": secondPlayerScore += 10; break;
//                            case "3": secondPlayerScore += 9; break;
//                            case "4": secondPlayerScore += 8; break;
//                            case "5": secondPlayerScore += 7; break;
//                            case "6": secondPlayerScore += 6; break;
//                            case "7": secondPlayerScore += 5; break;
//                            case "8": secondPlayerScore += 4; break;
//                            case "9": secondPlayerScore += 3; break;
//                            case "10": secondPlayerScore += 2; break;
//                            case "A": secondPlayerScore += 1; break;
//                            case "J": secondPlayerScore += 11; break;
//                            case "Q": secondPlayerScore += 12; break;
//                            case "K": secondPlayerScore += 13; break;
//                            case "Z": secondPlayerOverall *= 2; break;
//                            case "Y": secondPlayerOverall -= 200; break;
//                            case "X": if (xUsed2 == false)
//                                {
//                                    secondPlayerOverall += 50; xUsed2 = true;
//                                }; break;
//                        }
//                    }
                 
//                if (firstPlayerScore > secondPlayerScore)
//                {
//                    secondPlayerScore = 0;
//                    firstPlayerGamesWon++;
//                }
//                else if (firstPlayerScore < secondPlayerScore)
//                {
//                    firstPlayerScore = 0;
//                    secondPlayerGamesWon++;
//                }
//                else if (firstPlayerScore == secondPlayerScore)
//                {
//                    firstPlayerScore = 0;
//                    secondPlayerScore = 0;
//                }
//                }
//                firstPlayerOverall += firstPlayerScore;
//                secondPlayerOverall += secondPlayerScore;
//                firstPlayerScore = 0;
//                secondPlayerScore = 0;
//                count += 3;
//            }
//            if (firstPlayerOverall == secondPlayerOverall)
//            {
//                Console.WriteLine("It's a tie!");
//                Console.WriteLine("Score: " + (firstPlayerOverall + secondPlayerOverall) / 2);
//            }
//            else if (firstPlayerOverall > secondPlayerOverall)
//            {
//                Console.WriteLine("First player wins!");
//                Console.WriteLine("Score: " + firstPlayerOverall);
//                Console.WriteLine("Games won: " + firstPlayerGamesWon);
//            }
//            else
//            {
//                Console.WriteLine("Second player wins!");
//                Console.WriteLine("Score: " + secondPlayerOverall);
//                Console.WriteLine("Games won: " + secondPlayerGamesWon);
//            }
//        Finish:
//            ;
//        }
//    }
//}
    //    int games = int.Parse(Console.ReadLine());
    //    int playerOneScore = 0;
    //    int playerTwoScore = 0;

    //    BigInteger totalPointPlayerOne = 0;
    //    BigInteger totalPointPlayerTwo = 0;
    //    bool playerOneX = false;
    //    bool playerTwoX = false;

    //    for (int i = 0; i < games; i++)
    //    {
    //        BigInteger playerOnePoints = 0;
    //        BigInteger playerTwoPoints = 0;

    //        playerOneX = false;
    //        playerTwoX = false;

    //        for (int j = 0; j < 3; j++)
    //        {
    //            string cardPlayerOne = Console.ReadLine();
    //            switch (cardPlayerOne)
    //            {
    //                case "Z": totalPointPlayerOne *= 2; break;
    //                case "Y": totalPointPlayerOne -= 200; break;
    //                case "X": playerOneX = true; break;
    //                default: playerOnePoints += StringToNum(cardPlayerOne); break;
    //            }
    //        }
    //        for (int j = 0; j < 3; j++)
    //        {
    //            string cardPlayerTwo = Console.ReadLine();
    //            switch (cardPlayerTwo)
    //            {
    //                case "Z": totalPointPlayerTwo *= 2; break;
    //                case "Y": totalPointPlayerTwo -= 200; break;
    //                case "X": playerTwoX = true; break;
    //                default: playerTwoPoints += StringToNum(cardPlayerTwo); break;
    //            }
    //        }

    //        if (playerOneX && playerTwoX)
    //        {
    //            totalPointPlayerOne += 50;
    //            totalPointPlayerTwo += 50;
    //            playerOneX = false;
    //            playerTwoX = false;
    //        }
    //        else if (playerOneX)
    //        {
    //            break;
    //        }
    //        else if (playerTwoX)
    //        {
    //            break;
    //        }

    //        if (playerOnePoints > playerTwoPoints)
    //        {
    //            playerOneScore++;
    //            totalPointPlayerOne += playerOnePoints;
    //        }
    //        else if (playerOnePoints < playerTwoPoints)
    //        {
    //            playerTwoScore++;
    //            totalPointPlayerTwo += playerTwoPoints;
    //        }
    //    }

    //    if (playerOneX)
    //    {
    //        Console.WriteLine("X card drawn! Player one wins the match!");
    //    }
    //    else if (playerTwoX)
    //    {
    //        Console.WriteLine("X card drawn! Player two wins the match!");
    //    }
    //    else if (totalPointPlayerOne > totalPointPlayerTwo)
    //    {
    //        Console.WriteLine("First player wins!");
    //        Console.WriteLine("Score: {0}", totalPointPlayerOne);
    //        Console.WriteLine("Games won: {0}", playerOneScore);
    //    }
    //    else if (totalPointPlayerOne < totalPointPlayerTwo)
    //    {
    //        Console.WriteLine("Second player wins!");
    //        Console.WriteLine("Score: {0}", totalPointPlayerTwo);
    //        Console.WriteLine("Games won: {0}", playerTwoScore);
    //    }
    //    else
    //    {
    //        Console.WriteLine("It's a tie!");
    //        Console.WriteLine("Score: {0}", totalPointPlayerOne);
    //    }
    }
}