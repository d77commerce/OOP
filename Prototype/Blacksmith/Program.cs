using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            var steel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            var carbon = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int Gladius = 70;
            int gladiusRedy = 0;
            int Shamshir = 80;
            int shamshirRedy = 0;
            int Katana = 90;
            int katanaRedy = 0;
            int Sabre = 110;
            int sabreRedy = 0;
            int Broadsword = 150;
            int broadswordRedy = 0;
            int count = 0;

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int SteelTest = steel.Dequeue();
                int carbonTest = carbon.Pop();
                if (SteelTest + carbonTest == 70)
                {
                    gladiusRedy++;
                    count++;
                }
                else if (SteelTest + carbonTest == 80)
                {
                    shamshirRedy++;
                    count++;
                }
                else if (SteelTest + carbonTest == 90)
                {
                    katanaRedy++;
                    count++;
                }
                else if (SteelTest + carbonTest == 110)
                {
                    sabreRedy++;
                    count++;
                }
                else if (SteelTest + carbonTest == 150)
                {
                    broadswordRedy++;
                    count++;
                }
                else
                {
                    carbonTest += 5;
                    carbon.Push(carbonTest);
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"You have forged {count} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",carbon)}");

            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }
            if (broadswordRedy > 0)
            {
                Console.WriteLine($"Broadsword: {broadswordRedy}");
            }
            if (gladiusRedy > 0)
            {
                Console.WriteLine($"Gladius: {gladiusRedy}");
            }
            if (katanaRedy > 0)
            {
                Console.WriteLine($"Katana: {katanaRedy}");
            }
            if (sabreRedy > 0)
            {
                Console.WriteLine($"Sabre: {sabreRedy}");
            }
            if (shamshirRedy > 0)
            {
                Console.WriteLine($"Shamshir: {shamshirRedy}");
            }



        }
    }
}
