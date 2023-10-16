using System;
using System.Collections.Generic;
using System.Linq;

namespace Filtering
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> positiveNumbers = array.Where(num => num >= 0).ToList();

            foreach (int num in positiveNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}