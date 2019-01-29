using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem_6.__Auto_Repair_and_Service
{
    public class AutoRepairAndService
    {
        public static void Main()
        {
            var cars = new Queue<string>();
            var servedCars = new Stack<string>();

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(x => cars.Enqueue(x));

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service" && cars.Count > 0)
                {
                    string car = cars.Dequeue();
                    servedCars.Push(car);
                    Console.WriteLine($"Vehicle {car} got served.");
                }
                else if (command.Contains("CarInfo"))
                {
                    string[] token = command.Split("-");
                    if (servedCars.Contains(token[1]))
                    {
                        Console.WriteLine("Served.");
                    }
                    else if (cars.Contains(token[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
                command = Console.ReadLine();
            }

            if (cars.Count != 0)
            {
                Console.WriteLine("Vehicles for service: " + string.Join(", ", cars));
            }

            if (servedCars.Count != 0)
            {
                Console.WriteLine("Served vehicles: " + string.Join(", ", servedCars));
            }


        }
    }
}
