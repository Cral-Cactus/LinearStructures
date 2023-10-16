using System;
using System.Linq;

namespace LowestNumber
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int minimum = int.Parse(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i]);
                if (currentNumber < minimum)
                {
                    minimum = currentNumber;
                }
            }

            Console.WriteLine($"Lowest Number: {minimum}");
        }
    }
}