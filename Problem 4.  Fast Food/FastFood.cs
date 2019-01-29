using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4.__Fast_Food
{
    public class FastFood
    {
        public static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>();

            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .ForEach(x => orders.Enqueue(x));

            bool flag = false;
            int maxOrder = orders.Max();
            int orderCount = orders.Count;

            for (int i = 0; i < orderCount; i++)
            {
                quantityOfFood -= orders.Peek();

                if (quantityOfFood < 0)
                {
                    Console.WriteLine(maxOrder);
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                    flag = true;
                    break;
                }
                orders.Dequeue();
            }

            if (flag == false)
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
