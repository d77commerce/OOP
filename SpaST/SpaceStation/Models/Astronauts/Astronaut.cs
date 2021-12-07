using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;

        protected Astronaut(string name, double oxygen)
        {
            Name = name;
            Oxygen = oxygen;
        }

        public string Name
        {
            get => name;
           private set
            {
                if (value == " " && value == null)
                {
                    throw new ArgumentNullException(nameof(name), ExceptionMessages.InvalidAstronautName);
                }
                name = value;
            }
        }

        public double Oxygen
        {
            get => oxygen;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
                oxygen = value;
            }

        }

        public bool CanBreath => this.Oxygen > 0;

        public IBag Bag { get; set; }

        public void Breath()
        {
            throw new NotImplementedException();
        }
    }
}
