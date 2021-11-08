using MilitaryElite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.implementaion
{
    public class Commando : SpecialisedSoldier , ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get ; set ; }

        public void CompleteMission(string codeName)
        {
            var mission = this.Missions.FirstOrDefault(x => x.CodeName == codeName);
            mission.Status = Status.Finished;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string idInfo = base.ToString();
            sb.AppendLine(idInfo);
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
