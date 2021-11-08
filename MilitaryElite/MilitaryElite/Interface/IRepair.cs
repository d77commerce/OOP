using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
  public  interface IRepair
    {
        public string PartName { get; set; }
        public int WorkHours { get; set; }
    }
}
