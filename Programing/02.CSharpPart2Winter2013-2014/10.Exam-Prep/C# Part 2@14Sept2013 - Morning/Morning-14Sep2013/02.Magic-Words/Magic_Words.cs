namespace _02.Magic_Words
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Magic_Words
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int maxLenght = 0;

            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
                if (words[i].Length > maxLenght)
                {
                    maxLenght = words[i].Length;
                }
            }

            int[] indices = new int[n];
            for (int i = 0; i < n; i++)
            {
                indices[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                int newIndex = (words[indices[i]].Length % (n + 1));
                //newIndex = newIndex < 0 ? 0 : newIndex;
                int tempCell = indices[i];

                if (newIndex > i)
                {
                    newIndex--;
                    for (int j = i ; j < newIndex; j++)
                    {
                        indices[j] = indices[j + 1];
                    }

                    indices[newIndex] = tempCell;
                }
                else if (newIndex < i)
                {
                    for (int j = i; j > newIndex; j--)
                    {
                        indices[j] = indices[j - 1];
                    }

                    indices[newIndex] = tempCell;
                }
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < maxLenght; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result.Append(i < words[indices[j]].Length ? words[indices[j]][i] + "" : "" );
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
