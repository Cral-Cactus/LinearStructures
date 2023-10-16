using System;
using System.Collections.Generic;

namespace ReverseTheSequence
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            Console.WriteLine($"Enter {n} numbers:");

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Push(number);
            }

            Console.WriteLine("Reversed Sequence::");

            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                Console.WriteLine(number);
            }
        }
    }
}