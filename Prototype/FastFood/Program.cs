using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodRedy = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            int bigOrder = int.MinValue;
            foreach (var item in input)
            {
                queue.Enqueue(item);
                if (item > bigOrder)
                {
                    bigOrder = item;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (foodRedy - queue.Peek() >= 0)
                {
                    foodRedy -= queue.Dequeue();
                }
            }

            Console.WriteLine(bigOrder);
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");

            }
        }
    }
}
