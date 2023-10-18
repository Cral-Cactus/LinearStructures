using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) // DateTime.IsLeapYear(year) easier 😏
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");    
            }
        }
    }
}