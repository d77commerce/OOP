using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
       private  const int powerRogue = 80;
        public Rogue(string name)
            : base(name,powerRogue)
        {
        }
        public override string CastAbility()
        {
            return $"{GetType()} - { Name} hit for {Power} damage";
        }
    }
}
