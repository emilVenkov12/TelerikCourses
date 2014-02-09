using System;

class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        int step = 2;
        int crossbeamsRow = 1;
        for (int i = height - 1; i >= 0; i--)
        {
            string outerDots = new String('.', i);
            char midlleChar = '.';
            //check what need to be dot or slash
            if ((height - i - 1) == crossbeamsRow)
            {
                midlleChar = '-';
                crossbeamsRow += step;
                step++;
            }
            
            string innerChars = new String(midlleChar, (height - i - 1) * 2);
            Console.WriteLine("{0}/{1}\\{0}", outerDots, innerChars, outerDots);
        }
    }
}