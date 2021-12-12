using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCarOnGreenCros = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            Queue<string> carsOnTraficQueue = new Queue<string>();
            int carPassed = 0;
            while (action!="end")
            {
                if (action == "green")
                {
                    for (int i = 0; i < numOfCarOnGreenCros; i++)
                    {
                        if (carsOnTraficQueue.Count > 0)
                        {
                            Console.WriteLine($"{carsOnTraficQueue.Dequeue()} passed!");
                            carPassed++;

                        }
                    }
                }
                else
                {
                    carsOnTraficQueue.Enqueue(action);
                }


                action = Console.ReadLine();
            }
            Console.WriteLine($"{carPassed} cars passed the crossroads.");

        }
    }
}
