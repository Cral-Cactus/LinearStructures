using System;
using System.Linq;

namespace BiggestNumberOutOfThree
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num1 = input[0];
            int num2 = input[1];
            int num3 = input[2];

            int maxNumber = input[0];

            if (num2 > maxNumber)
            {
                maxNumber = num2;
            }
            if (num3 > maxNumber)
            {
                  maxNumber = num3;
            }

            Console.WriteLine(maxNumber);
        }
    }
}