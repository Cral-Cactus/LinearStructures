using System;
using System.Collections.Generic;
using System.Linq;

namespace FilteringOddNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in numbers)
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

            List<int> filteredNumbers = numbers.Where(num => counts[num] % 2 == 0).ToList();

            foreach (int num in filteredNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}