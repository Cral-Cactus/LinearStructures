using System;

namespace CarPlate
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int firstTwoDigitsSum = number / 1000 + (number / 100) % 10;
            int lastTwoDigitsSum = (number / 10) % 10 + number % 10;

            if (firstTwoDigitsSum == lastTwoDigitsSum)
            {
                Console.WriteLine("The car plate is lucky!");
            }
            else
            {
                Console.WriteLine("The car plate is not lucky.");
            }
        }
    }
}