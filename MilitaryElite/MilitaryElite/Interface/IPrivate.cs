using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
  public  interface IPrivate : ISoldier
    {
        public decimal Salary { get; set; }
    }
}
