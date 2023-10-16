using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAndAverage
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            int count = input.Count;

            foreach (int number in input)
            {
                sum += number;
            }

            double average = count > 0 ? (double)sum / count : 0;
            average = Math.Round(average, 2);

            Console.WriteLine($"Sum={sum}; Average={average.ToString("F2")}");
        }
    }
}