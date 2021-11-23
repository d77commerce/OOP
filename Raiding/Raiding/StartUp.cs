using System;

namespace Raiding
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int point = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               string name = Console.ReadLine();
                string type = Console.ReadLine();
               
                if (type == "Warrior")
                {
                    Hero warrior = new Warrior(name);
                    point +=warrior.Power;
                }
                else if (type == "Rogue")
                {
                    Hero rogue = new Rogue(name);
                    point += rogue.Power;
                }
                else if (type == "Paladin")
                {
                    Hero paladin = new Paladin(name);
                    point += paladin.Power;
                }
                else if (type == "Druid")
                {
                    Hero druid = new Druid(name);
                    point += druid.Power;
                }

            }
            int powerBoss = int.Parse(Console.ReadLine());
            Console.WriteLine(point.CompareTo(powerBoss));


        }
    }
}
