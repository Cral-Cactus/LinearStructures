using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsMerge
{
    internal class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> mergedList = list1.Concat(list2).OrderBy(x => x).ToList();

            Console.WriteLine($"Merged List: {string.Join(" ", mergedList)}");
        }
    }
}