using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            if (astronauts.All(x => x.Oxygen < 0))
            {

            }
            foreach (var astronaut in astronauts)
            {
                if (astronaut.CanBreath && planet.Items.Any())
                {
                    var newItem = planet.Items.FirstOrDefault();
                    astronaut.Bag.Items.Add(newItem);
                    planet.Items.Remove(newItem);
                    astronaut.Breath();

                }



            }
        }
    }
}
