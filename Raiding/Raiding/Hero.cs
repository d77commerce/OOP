using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    interface Hero
    {
        public string Name { get; set; }
        int Power { get; }
        public string CastAbility();
    }
}
