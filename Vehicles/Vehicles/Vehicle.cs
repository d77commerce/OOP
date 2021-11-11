using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double consumption;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double consumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.Consumption = consumption;

        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }

        public double Consumption { get => consumption; set => consumption = value; }
        public double TankCapacity { get => tankCapacity; set => tankCapacity = value; }
        public abstract void Driven(double distance);
        public abstract void Refuel(double fuelInTo);

    }
}
