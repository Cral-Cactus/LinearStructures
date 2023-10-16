using System;
using System.Linq;

namespace SearchInArray
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int search = int.Parse(Console.ReadLine());

            int result = -1;
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (array[middle] == search)
                {
                    result = middle;
                    Console.WriteLine($"{search} Exists in the Array at index {result}");
                    break;
                }
                else if (search < array[middle])
                {
                    end = middle - 1;
                }
                else if (search > array[middle])
                {
                    start = middle + 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine($"{search} Not exists in the Array");
            }
        }
    }
}