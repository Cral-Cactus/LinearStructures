using System;
using System.Linq;

namespace SortTreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num1 = input[0];
            int num2 = input[1];
            int num3 = input[2];

            int temp;
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num2 > num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine($"Sorted in ascending order: {num1} {num2} {num3}");

            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num2 < num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            if (num1 < num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine($"Sorted in descending order: {num1} {num2} {num3}");
        }
    }
}