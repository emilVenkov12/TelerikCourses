using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            string outerDots = new String('.', (n / 2) - (i + 1));
            string innerDots = new String('.', i * 2);
            Console.WriteLine("{0}#{1}#{0}", outerDots, innerDots);
        }

        for (int i = 0; i < n / 4; i++)
        {
            string outerDots = new String('.', i);
            string innerDots = new String('.', (n - 2) - 2 * i);
            Console.WriteLine("{0}#{1}#{0}", outerDots, innerDots);
        }
        Console.WriteLine(new String('-', n));

        for (int i = 0; i < n / 2; i++)
        {
            string outerDots = new String('.', i);
            string slashes = new String('\\', (n / 2) - i);
            string backSlashes = new String('/', (n / 2) - i);
            Console.WriteLine("{0}{1}{2}{0}", outerDots, slashes, backSlashes);
        }
    }
}
