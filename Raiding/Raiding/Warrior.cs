using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Warrior : BaseHero
    {
        private const int powerWarrior = 100;
        public Warrior(string name) 
            : base(name,powerWarrior)
        {
        }

        public override string CastAbility()
        {
            return $"{GetType()} - {Name} hit for {Power} damage";
        }
    }
}
