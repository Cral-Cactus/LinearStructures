using System;
using System.Collections.Generic;
using System.IO;

namespace BFSwidthCrawl
{
    internal class Program
    {
        static void Main()
        {
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                Queue<string> queue = new Queue<string>();
                queue.Enqueue(directoryPath);

                while (queue.Count > 0)
                {
                    string currentDirectory = queue.Dequeue();
                    Console.WriteLine(currentDirectory);

                    string[] subdirectories = Directory.GetDirectories(currentDirectory);
                    foreach (string subdirectory in subdirectories)
                    {
                        queue.Enqueue(subdirectory);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong way to the directory!.");
            }
        }
    }
}