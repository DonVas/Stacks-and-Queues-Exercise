using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5.__Fashion_Boutique
{
    public class FashionBoutique
    {
        public static void Main()
        {
            Stack<int> clothes = new Stack<int>();

            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .ForEach(x => clothes.Push(x));

            int boxCapacity = int.Parse(Console.ReadLine());
            int currSum = 0;
            int numberOfBox = 1;

            while (clothes.Count != 0)
            {
                if (currSum + clothes.Peek() <= boxCapacity)
                {
                    currSum += clothes.Pop();
                }
                else
                {
                    currSum = 0;
                    numberOfBox++;
                }
            }
            Console.WriteLine(numberOfBox);
        }
    }
}
