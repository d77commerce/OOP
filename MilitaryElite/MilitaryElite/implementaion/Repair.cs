using MilitaryElite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.implementaion
{
    class Repair : IRepair
    {
        public Repair(string partName, int workHours)
        {
            PartName = partName;
            WorkHours = workHours;
        }

        public string PartName { get; set ; }
        public int WorkHours { get; set; }
        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {WorkHours}";
        }
    }
}
