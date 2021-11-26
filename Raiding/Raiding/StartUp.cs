using System;

namespace Raiding
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int point = 0;
            int n = int.Parse(Console.ReadLine());
            int herosColection = 0;
            while(herosColection!=n)
            {
               string name = Console.ReadLine();
                string type = Console.ReadLine();
               
                if (type == "Warrior")
                {
                    Hero warrior = new Warrior(name);
                    point +=warrior.Power;
                    herosColection++;
                    Console.WriteLine(warrior.CastAbility());
                }
                else if (type == "Rogue")
                {
                    Hero rogue = new Rogue(name);
                    point += rogue.Power;
                    herosColection++;
                    Console.WriteLine(rogue.CastAbility());
                }
                else if (type == "Paladin")
                {
                    Hero paladin = new Paladin(name);
                    point += paladin.Power;
                    herosColection++;
                    Console.WriteLine(paladin.CastAbility());
                }
                else if (type == "Druid")
                {
                    Hero druid = new Druid(name);
                    point += druid.Power;
                    herosColection++;
                    Console.WriteLine(druid.CastAbility());
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }

            }
            int powerBoss = int.Parse(Console.ReadLine());
            int result = point.CompareTo(powerBoss);
            if (result >=0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }


        }
    }
}
