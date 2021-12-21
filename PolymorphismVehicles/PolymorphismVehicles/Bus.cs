using PolymorphismVehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismVehicles
{
    public class Bus : IVehicle
    {
        private double fuelQuantity;

        public Bus(double fuelQuantity, double fuelPerKm, double tankCapacity)
        {
            FuelPerKm = fuelPerKm;
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
        }
        public double TankCapacity { get; set; }
        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;

                }
                else
                {
                    fuelQuantity = value;
                }

            }
        }
        public double FuelPerKm { get; set; }


        public void DriveEmpty(double distans)
        {
            if (fuelQuantity - (distans * FuelPerKm) >= 0)
            {
                fuelQuantity -= distans * FuelPerKm;
                Console.WriteLine($"{GetType().Name} travelled {distans} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }
        public void Drive(double distans)
        {
            if (fuelQuantity - (distans * (FuelPerKm+1.4)) >= 0)
            {
                fuelQuantity -= distans * (FuelPerKm + 1.4);
                Console.WriteLine($"{GetType().Name} travelled {distans} km");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
        }

        public void Refil(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");

            }
            else if (liters + fuelQuantity > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                fuelQuantity += liters;
            }
        }
    }
}
