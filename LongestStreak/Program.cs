using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestStreak
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> longestSequence = FindLongestSequence(numbers);

            Console.WriteLine($"Longest Streak: {string.Join(" ", longestSequence)}");
        }

        static List<int> FindLongestSequence(List<int> numbers)
        {
            List<int> longestSequence = new List<int>();
            List<int> currentSequence = new List<int> { numbers[0] };

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence.Add(numbers[i]);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence = new List<int> { numbers[i] };
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }

            return longestSequence;
        }
    }
}