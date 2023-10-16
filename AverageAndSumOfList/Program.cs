using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageAndSumOfList
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine($"Average: {input.Average()}");
            Console.WriteLine($"Sum: {input.Sum()}");
        }
    }
}