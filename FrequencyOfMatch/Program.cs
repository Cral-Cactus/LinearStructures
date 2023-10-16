using System;
using System.Collections.Generic;
using System.IO;

namespace FrequencyOfMatch
{
    internal class Program
    {
        static void Main()
        {
            string directoryPath = Console.ReadLine();

            if (Directory.Exists(directoryPath))
            {
                Stack<string> stack = new Stack<string>();
                stack.Push(directoryPath);

                while (stack.Count > 0)
                {
                    string currentDirectory = stack.Pop();
                    Console.WriteLine(currentDirectory);

                    string[] subdirectories = Directory.GetDirectories(currentDirectory);
                    foreach (string subdirectory in subdirectories)
                    {
                        stack.Push(subdirectory);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong way to the directory.");
            }
        }
    }
}