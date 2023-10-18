using System;
using System.Linq;

namespace LowestNumOutOfFour
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num1 = input[0];
            int num2 = input[1];
            int num3 = input[2];
            int num4 = input[3];

            int lowest = num1;

            if (num2 < lowest)
            {
                lowest = num2;
            }
            if (num3 < lowest)
            {
                lowest = num3;
            }
            if (num4 < lowest)
            {
                lowest = num4;
            }

            Console.WriteLine($"The lowest number is: {lowest}");
        }
    }
}