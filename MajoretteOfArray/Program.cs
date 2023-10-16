using System;
using System.Collections.Generic;

namespace MajoretteOfArray
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');

            int[] array = new int[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
            {
                array[i] = int.Parse(numbersStr[i].Trim());
            }

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            int threshold = array.Length / 2 + 1;
            foreach (var pair in counts)
            {
                if (pair.Value >= threshold)
                {
                    Console.WriteLine(pair.Key);
                    return;
                }
            }

            Console.WriteLine("The majorant does not exists!");
        }
    }
}