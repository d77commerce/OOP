using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
  public abstract  class Vehicle
    {
        protected Vehicle(double fuelQuantity, double consumption)
        {
            FuelQuantity = fuelQuantity;
            Consumption = consumption;
        }

        public double  FuelQuantity { get; set; }
        public double Consumption { get; set; }

        public abstract void Driven(double distance);
        public abstract void Refuel(double fuelInTo);
       
    }
}
