using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOrAddMethod
{
    internal class Program
    {
        static void Main()
        {
            List<int> sortedList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int numberToCheck = int.Parse(Console.ReadLine());

            if (sortedList.Contains(numberToCheck))
            {
                sortedList.Remove(numberToCheck);
            }
            else
            {
                int index = 0;
                while (index < sortedList.Count && sortedList[index] < numberToCheck)
                {
                    index++;
                }
                sortedList.Insert(index, numberToCheck);
            }

            Console.WriteLine("New List: " + string.Join(" ", sortedList));
            Console.WriteLine("Input List: " + string.Join(" ", sortedList));
        }
    }
}