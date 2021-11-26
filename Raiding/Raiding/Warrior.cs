using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
   public class Warrior : BaseHero
    {
        private const int powerWarrior = 100;
        public Warrior(string name) 
            : base(name,powerWarrior)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
