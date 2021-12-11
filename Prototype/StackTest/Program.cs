using System;
using System.Collections.Generic;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
          while (stack.Peek()!=0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
