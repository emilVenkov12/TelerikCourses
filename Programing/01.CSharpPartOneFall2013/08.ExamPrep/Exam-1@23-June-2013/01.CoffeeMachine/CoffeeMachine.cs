using System;

class CoffeeMachine
{
    static void Main()
    {
        decimal[] moneyKinds = new decimal[] { 0.05M, 0.10M, 0.20M, 0.50M, 1M };
        decimal totalMoney = 0;
 
        int slotsCount = 5;
 
        for (int i = 0; i < slotsCount; i++)
        {
            totalMoney += int.Parse(Console.ReadLine()) * moneyKinds[i];
        }
 
        decimal userAmount = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());
 
        decimal change = userAmount - drinkPrice;
 
        if (drinkPrice <= userAmount)
        {
            if (change <= totalMoney)
            {
                Console.WriteLine("Yes {0:F2}", totalMoney - change);
            }
            else
            {
                Console.WriteLine("No {0:F2}", change - totalMoney);
            }
        }
        else if (drinkPrice > userAmount)
        {
            Console.WriteLine("More {0:F2}", drinkPrice - userAmount);
        }
    }
}
