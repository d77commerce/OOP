using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals
{
    public abstract class Felines : Mammal
    {
        protected Felines(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }
        public string Breed { get; set; }
     
    }
}
