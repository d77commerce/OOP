using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    class PlanetRepository : IRepository<IPlanet>
    {
        public readonly List<IPlanet> planets;
        public PlanetRepository()
        {
           this.planets  = new List<IPlanet>(); 
        }
        public IReadOnlyCollection<IPlanet> Models => planets;

        public void Add(IPlanet model)
        {
           this.planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            return this.planets.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IPlanet model)
        {
            return this.planets.Remove(model);
        }
    }
}
