using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double consumption,double tankCapacity)
            : base(fuelQuantity, consumption,tankCapacity)
        {
        }

        public override void Driven(double distance)
        {
            double sumerComsumation = Consumption + 1.6;
            if (distance* sumerComsumation<= FuelQuantity)
            {
                FuelQuantity -= distance * sumerComsumation;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }

        }

        public override void Refuel(double fuelInTo)
        {
            if (TankCapacity >= fuelInTo + FuelQuantity && fuelInTo >0)
            {
                FuelQuantity += fuelInTo*0.95;
            }
            else
            {
                if (fuelInTo <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");

                }
                else
                {
                    Console.WriteLine($"Cannot fit {fuelInTo} fuel in the tank");
                }
            }
        }
    }
}
