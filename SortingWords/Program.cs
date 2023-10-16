using System;
using System.Collections.Generic;

namespace SortingWords
{
    internal class Program
    {
        static void Main()
        {
            List<string> words = new List<string>(Console.ReadLine().Split(' '));

            for (int i = 0; i < words.Count - 1; i++)
            {
                string minimum = words[i];
                int minimumPos = i;

                for (int j = i + 1; j < words.Count; j++)
                {
                    if (string.Compare(words[j], minimum) < 0)
                    {
                        minimum = words[j];
                        minimumPos = j;
                    }
                }

                words[minimumPos] = words[i];
                words[i] = minimum;
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}