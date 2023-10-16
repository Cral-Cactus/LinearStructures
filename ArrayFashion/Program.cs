using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayFashion
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

            int maxFrequency = counts.Values.Max();
            List<int> modes = counts.Where(pair => pair.Value == maxFrequency).Select(pair => pair.Key).ToList();

            if (modes.Count == 1)
            {
                Console.WriteLine($"Fashion: {modes[0]}");
            }
            else
            {
                double average = modes.Average();
                Console.WriteLine($"Fashions: {string.Join(", ", modes)}");
                Console.WriteLine($"Average value of the fashions: {average}");
            }
        }
    }
}