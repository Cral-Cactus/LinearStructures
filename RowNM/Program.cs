using System;
using System.Collections.Generic;

namespace RowNM
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length != 2 || !int.TryParse(parts[0], out int n) || !int.TryParse(parts[1], out int m))
            {
                Console.WriteLine("Invalid Input.");
                return;
            }

            FindShortestSequence(n, m);
        }

        static void FindShortestSequence(int n, int m)
        {
            Queue<SequenceItem> queue = new Queue<SequenceItem>();
            queue.Enqueue(new SequenceItem(n, null));

            while (queue.Count > 0)
            {
                SequenceItem current = queue.Dequeue();

                if (current.Value < m)
                {
                    queue.Enqueue(new SequenceItem(current.Value + 1, current));
                    queue.Enqueue(new SequenceItem(current.Value + 2, current));
                    queue.Enqueue(new SequenceItem(current.Value * 2, current));
                }
                else if (current.Value == m)
                {
                    PrintSolution(current);
                    return;
                }
            }

            Console.WriteLine("No solution.");
        }

        static void PrintSolution(SequenceItem item)
        {
            Stack<int> sequence = new Stack<int>();
            while (item != null)
            {
                sequence.Push(item.Value);
                item = item.Previous;
            }

            Console.WriteLine("Shortest row: " + string.Join(" -> ", sequence));
        }
    }
}