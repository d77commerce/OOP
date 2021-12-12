using System;
using System.Collections.Generic;
using System.Linq;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] num = Console.ReadLine().Split(' ');

            Stack<int> stack = new Stack<int>();

            foreach (var item in num)
            {
                stack.Push(int.Parse(item));
            }

            while (true)
            {
                string inPut = Console.ReadLine();
                string[] inputToArray = inPut.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string comand = inputToArray[0].ToLower();
                if (comand == "add")
                {
                    stack.Push(int.Parse(inputToArray[1]));
                    stack.Push(int.Parse(inputToArray[2]));
                }
                else if (comand == "remove")
                {
                    int numToRemove = int.Parse(inputToArray[1]);
                    if (numToRemove <= stack.Count)
                    {
                        for (int i = 0; i < numToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (comand == "end")
                {
                    break;
                }
              
            }
            
            Console.WriteLine($"Sum: {stack.Sum()}");


        }
    }
}
