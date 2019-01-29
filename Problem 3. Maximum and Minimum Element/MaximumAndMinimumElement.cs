using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Maximum_and_Minimum_Element
{
    public class MaximumAndMinimumElement
    {
        public static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            int maxElement = 0;
            int buffMaxElement = 0;
            int buffMinElement = 0;
            int minElemen = 109;
            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (commands[0] == 1)
                {
                    stack.Push(commands[1]);

                    if (maxElement < commands[1])
                    {
                        buffMaxElement = maxElement;
                        maxElement = commands[1];
                    }

                    if (minElemen > commands[1])
                    {
                        buffMinElement = minElemen;
                        minElemen = commands[1];
                    }

                }
                else if (commands[0] == 2 && stack.Count != 0)
                {
                    int maxCurrent = stack.Pop();

                    if (maxCurrent == maxElement)
                    {
                        maxElement = buffMaxElement;
                    }
                    if (maxCurrent == minElemen)
                    {
                        minElemen = buffMinElement;
                    }
                }
                else if (commands[0] == 3 && stack.Count != 0)
                {
                    Console.WriteLine(maxElement);

                }
                else if (commands[0] == 4 && stack.Count != 0)
                {
                    Console.WriteLine(minElemen);

                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
