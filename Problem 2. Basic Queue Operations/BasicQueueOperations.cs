using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Basic_Queue_Operations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {

            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //number of stack elements
            int numberOfElements = tokens[0];
            // number of elements to be pop(out and remove)
            int elementsToDequeue = tokens[1];
            //find if exist elemnet
            int elementToFind = tokens[2];

            Queue<int> queue = new Queue<int>();

            List<int> elementsInts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            elementsInts.ForEach(x => queue.Enqueue(x));

            for (int i = 0; i < elementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
