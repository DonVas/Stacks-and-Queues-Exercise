using System;
using System.Collections.Generic;

namespace Problem_10.__Crossroads
{
    public class Crossroads
    {
        public static void Main()
        {
            Queue<string> carsQueue = new Queue<string>();
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int windowSeconds = int.Parse(Console.ReadLine());
            int buff = greenLightSeconds;
            int carsOK = 0;
            int index = 0;
            bool flagCrash = false;

            while (true)
            {
                string token = Console.ReadLine();

                if (token == "END" || flagCrash == true)
                {
                    break;
                }
                else if (token == "green")
                {
                    bool end = false;
                    for (int i = 0; i < carsQueue.Count; i++)
                    {
                        int carLenght = carsQueue.Peek().Length;
                        if (greenLightSeconds - carLenght > 0)
                        {
                            greenLightSeconds = greenLightSeconds - carLenght;
                            carsQueue.Dequeue();
                            carsOK++;
                            i--;
                        }
                        else if (greenLightSeconds + windowSeconds - carLenght >= 0 && end != true)
                        {
                            greenLightSeconds = greenLightSeconds + windowSeconds - carLenght;
                            carsQueue.Dequeue();
                            carsOK++;
                            i--;
                            end = true;
                        }
                        else if (end == true)
                        {
                            break;
                        }
                        else
                        {
                            index = greenLightSeconds + windowSeconds;
                            flagCrash = true;
                            break;
                        }
                    }

                    greenLightSeconds = buff;
                }
                else
                {
                    carsQueue.Enqueue(token);
                }
            }

            if (flagCrash)
            {
                Console.WriteLine("A crash happened!");
                string car = carsQueue.Peek().ToString();
                Console.WriteLine($"{car} was hit at {car[index]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsOK} total cars passed the crossroads.");
            }
        }
    }
}
