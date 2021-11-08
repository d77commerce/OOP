using MilitaryElite.implementaion;
using MilitaryElite.Interface;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split();
                string infoType = info[0];
                int id = int.Parse(info[1]);
                string firstName = info[2];
                string lastName = info[3];

                if (infoType == "Private")
                {
                    decimal salary = decimal.Parse(info[4]);
                    IPrivate @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(id,@private);
                }
                else if(infoType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(info[4]);
                    ILieutenantGeneral lieutenantGeneral= new LieutenantGeneral(id, firstName, lastName, salary);
                    for (int i = 5; i < info.Length; i++)
                    {
                        int idInput = int.Parse(info[i]);
                        IPrivate @private = soldiers[idInput] as IPrivate;
                        lieutenantGeneral.Privates.Add(@private);
                    }
                    soldiers.Add(id, lieutenantGeneral);

                }
                else if (infoType == "Engineer")
                {
                    decimal salary = decimal.Parse(info[4]);
                    string corpAsString = info[5];
                    bool isValidEnum = Enum.TryParse<Corps>(corpAsString, out Corps result);
                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);
                    for (int i = 6; i < info.Length; i+=2)
                    {
                        IRepair repair = new Repair(info[i], int.Parse(info[i + 1]));
                        engineer.Repairs.Add(repair);
                    }
                    soldiers.Add(id, engineer);

                }
                else if (infoType== "Commando")
                {
                    decimal salary = decimal.Parse(info[4]);
                    string corpAsString = info[5];
                    bool isValidEnum = Enum.TryParse<Corps>(corpAsString, out Corps result);
                    if (!isValidEnum)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    ICommando commando = new Commando(id, firstName, lastName, salary,result);
                    for (int j = 6; j < info.Length; j+=2)
                    {
                        string missionCode = info[j];
                        string missionAsState = info[j + 1];
                        bool isValidMission = Enum.TryParse(missionAsState, out Status status);
                        if (!isValidMission)
                        {
                            continue;
                        }
                        IMission mission = new Mission(missionCode, status);
                        commando.Missions.Add(mission);
                    }
                    soldiers.Add(id, commando);

                }
                else if (infoType== "Spy")
                {
                    int codeNum = int.Parse(info[4]);
                    ISpy spy = new Spy(id, firstName, lastName, codeNum);
                    soldiers.Add(id, spy);
                }
                input = Console.ReadLine();
            }
            foreach (var item in soldiers)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }
    }
}
