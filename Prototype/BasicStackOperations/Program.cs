using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inPut = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse).ToArray();
            int NomberAdd = inPut[0];
            int NomberRemuve = inPut[1];
            int MajickNomber = inPut[2];
            Stack<int> stack = new Stack<int>();
            int[] nombers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse).ToArray();

            if (NomberAdd <= NomberRemuve)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < NomberAdd; i++)
            {
                stack.Push(nombers[i]);
            }
            for (int i = 0; i < NomberRemuve; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(MajickNomber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Peek());
            }
        }
    }
}
