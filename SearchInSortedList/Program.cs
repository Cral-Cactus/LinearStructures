using System;
using System.Linq;
using System.Collections.Generic;

namespace SearchInSortedList
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();
            int numberToCheck = int.Parse(Console.ReadLine());

            if (input.Contains(numberToCheck))
            {
                Console.WriteLine($"{numberToCheck} Exists in the List");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} Not exists in the List");
            }
        }
    }
}