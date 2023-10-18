using System;
using System.Collections.Generic;

namespace ReversingNumbersWithSteck
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');

            Stack<int> stack = new Stack<int>();

            foreach (string numStr in numbersStr)
            {
                if (int.TryParse(numStr, out int number))
                {
                    stack.Push(number);
                }
            }

            while (stack.Count > 0)
            {
                int number = stack.Pop();
                Console.Write(number + " ");
            }
        }
    }
}