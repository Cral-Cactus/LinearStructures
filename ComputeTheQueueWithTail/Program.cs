using System;
using System.Collections.Generic;

namespace ComputeTheQueueWithTail
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(N);

            int count = 1;
            while (count <= 50)
            {
                int currentNumber = sequence.Dequeue();
                Console.Write($"{currentNumber} ");

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue(2 * currentNumber + 1);
                sequence.Enqueue(currentNumber + 2);

                count += 3;
            }
        }
    }
}