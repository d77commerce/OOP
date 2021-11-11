using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {
        }

        public override void Driven(double distance)
        {
            double sumerComsumation = Consumption + 1.4;
            if (sumerComsumation * distance <= FuelQuantity)
            {
                FuelQuantity -= distance * sumerComsumation;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double fuelInTo)
        {
           if (TankCapacity >= fuelInTo + FuelQuantity && fuelInTo>0)
            {
                FuelQuantity += fuelInTo;
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
        public void DriveEmpty(double distance)
        {
            if (Consumption * distance <= FuelQuantity)
            {
                FuelQuantity -= distance * Consumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");

            }
        }
    }
}
