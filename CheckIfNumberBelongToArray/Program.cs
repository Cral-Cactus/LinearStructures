using System;
using System.Linq;

namespace CheckIfNumberBelongToArray
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberToCheck = int.Parse(Console.ReadLine());

            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine($"{numberToCheck} - Exists in the List");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} - Does not exists in the List");
            }
        }
    }
}