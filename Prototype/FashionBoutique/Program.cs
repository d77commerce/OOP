using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capasityOfRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int racks = 0;
            int action = 0;
            foreach (var item in input)
            {
                stack.Push(item);
            }
            while (true)
            {
                if (capasityOfRack >= stack.Peek() + action)
                {
                    action += stack.Pop();
                }
                else if (action > 0)
                {
                    racks++;
                    action = 0;
                }


                if (stack.Count == 0)
                {
                    if (action > 0)
                    {
                        Console.WriteLine(racks + 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        break;
                    }

                }
            }
        }
    }
}
