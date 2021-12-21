using PolymorphismVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismVehicles
{
    internal class Truck : IVehicle
    {
       

        public Truck(double fuelQuantity, double fuelPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelPerKm = fuelPerKm;
        }

        public double FuelQuantity {get;set;}
        public double FuelPerKm { get;set;}

        public void Drive(double distans)
        {
            if (FuelQuantity - (distans * (FuelPerKm + 1.6)) >= 0)
            {
                FuelQuantity -= distans *( FuelPerKm + 1.6);
                Console.WriteLine($"{GetType().Name} travelled {distans} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public void Refil(double liters)
        {
            FuelQuantity +=liters*0.95;
        }
    }
}
