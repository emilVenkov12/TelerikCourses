using System;

class Garden
{
    static void Main()
    {
        int totalArea = 250;
        double[] prices = new double[] { 0.5, 0.4, 0.25, 0.6, 0.3, 0.4 };
        double totalCosts = 0;
        int plantedArea = 0;

        for (int i = 0; i < 5; i++)
        {
            totalCosts += int.Parse(Console.ReadLine()) * prices[i];
            plantedArea += int.Parse(Console.ReadLine());
        }
        totalCosts += int.Parse(Console.ReadLine()) * prices[5];

        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        if (plantedArea > totalArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (totalArea - plantedArea > 0)
        {
            Console.WriteLine("Beans area: {0}", totalArea - plantedArea);
        }
        else
        {
            Console.WriteLine("No area for beans");
        }
    }
}