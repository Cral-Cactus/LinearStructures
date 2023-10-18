using System;

namespace Area
{
    internal class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double result = 0;

            if (x == 1)
            {
                result = 3 * a;
                Console.WriteLine(result);
            }
            else if (x == 2)
            {
                result = a * a;
                Console.WriteLine(result);
            }
            else if (x == 3)
            {
                result = Math.PI * a * a;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input for x. Please enter 1, 2, or 3.");
            }
        }
    }
}