namespace _03.Indices
{
    using System;
    using System.Linq;
    using System.Text;

    class Indices
    {
        static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool[] visited = new bool[numbersCount];

            int currentIndex = 0,
                prevIndex = -1;
            bool isLoop = false;
            while (true)
            {
                if (visited[currentIndex])
                {
                    isLoop = true;
                    break;
                }
                else
                {
                    visited[currentIndex] = true;
                    if (numbers[currentIndex] <= numbersCount - 1 && numbers[currentIndex] >= 0)
                    {
                        prevIndex = currentIndex;
                        currentIndex = numbers[currentIndex];
                    }
                    else
                    {
                        break; // finish without loop
                    }
                }
            }

            StringBuilder output = new StringBuilder();

            int index = numbers[0];
            output.Append("0 " + prevIndex);
            while (index != currentIndex)
            {
                output.Append(" " + numbers[index]);
                index = numbers[index];
            }

            if (isLoop)
            {

                output.Append('(');
                output.Append(currentIndex);
                while (index != prevIndex)
                {
                    output.Append(" " + numbers[index]);
                    index = numbers[index];
                }
                output.Append(')');
            }

            Console.WriteLine(output.ToString());
        }
    }
}
