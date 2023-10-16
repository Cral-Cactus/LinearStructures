using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequencyOfOccurrence
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}