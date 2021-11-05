using System;
using System.Linq;

namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            ListyIterator<string> listy = null;
            while (command!="END")
            {
                string[] action = command.Split(" ");
                if (action[0]== "Create")
                {
                    listy = new ListyIterator<string>(action.Skip(1).ToArray());
                }
                else if (action[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (action[0] == "Print")
                {
                    listy.Print();
                }
                else if (action[0]== "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (action[0] == "PrintAll")
                {
                    listy.PrintAll();
                }

                command = Console.ReadLine();
            }
        }
    }
}
