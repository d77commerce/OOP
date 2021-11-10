using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double consumption) 
            : base(fuelQuantity, consumption)
        {
        }

        public override void Driven(double distance)
        {
            double sumerComsumation = Consumption + 0.9;
            if ( sumerComsumation*distance <= FuelQuantity)
            {
                FuelQuantity -= distance * sumerComsumation;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double fuelInTo)
        {
            FuelQuantity += fuelInTo;
        }
    }
}
