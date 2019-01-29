using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7.__Truck_Tour
{
    public class TruckTour
    {
        private static Queue<int[]> pumps;
        public static void Main()
        {
            int lineOfValue = int.Parse(Console.ReadLine());

            pumps = new Queue<int[]>();

            for (int i = 0; i < lineOfValue; i++)
            {
                pumps.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            }

            for (int i = 0; i < lineOfValue; i++)
            {
                if (CheckIsAnsuwer(lineOfValue))
                {
                    Console.WriteLine(i);
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
            }

        }

        public static bool CheckIsAnsuwer(int numberOfPumps)
        {
            int tankFuel = 0;
            bool flagFound = true;

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] currentPump = pumps.Dequeue();
                tankFuel += currentPump[0] - currentPump[1];
                if (tankFuel < 0)
                {
                    flagFound = false;
                }
                pumps.Enqueue(currentPump);
            }

            if (flagFound)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
