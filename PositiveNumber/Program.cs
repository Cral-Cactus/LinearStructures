using System;

namespace PositiveNumber
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            if (firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit)
            {
                Console.WriteLine("There are at least two equal digits in the number.");
            }
            else
            {
                Console.WriteLine("There are no two equal digits in the number.");
            }
        }
    }
}