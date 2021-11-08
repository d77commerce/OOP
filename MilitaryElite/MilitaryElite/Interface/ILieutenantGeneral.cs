using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface ILieutenantGeneral : IPrivate
    {
        public List<IPrivate> Privates { get; set; }
    }
}
